﻿using CZBK.ItcastOA.BLL;
using CZBK.ItcastOA.Model;
using CZBK.ItcastOA.Model.SearchParam;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CZBK.ItcastOA.WebApp.Controllers
{
    public class ShareFileOrNoticeController : BaseController
    {
        IBLL.IShareFileOrNoticeService ShareFileOrNoticeService { get; set; }
        IBLL.IShareTypeService ShareTypeService { get; set; }
        IBLL.IBumenInfoSetService BumenInfoSetService { get; set; }
        IBLL.IUserInfoService UserInfoService { get; set; }
        IBLL.IFileTypeService FileTypeService { get; set; }

        // GET: /ShareFileOrNotice/

        public ActionResult Index()
        {
            return View();
        }
        //获取共享文件
        public ActionResult GetShareFile()
        {
            int userID = LoginUser.ID;
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ID > 0).DefaultIfEmpty().ToList();
            int pageIndex = Request["page"] != null ? int.Parse(Request["page"]) : 1;
            int pageSize = Request["rows"] != null ? int.Parse(Request["rows"]) : 25;
            int TotalCount = 0;
            List<ShareFileOrNotice> sfon = new List<ShareFileOrNotice>();
            if (temp[0] != null)
            {
                #region MyRegion
                foreach (var a in temp)
                {
                    if (a.TypeID == 1)
                    {
                        if (a.ShareUser == userID)
                        {
                            sfon.Add(a);
                            continue;
                        }
                        else
                        {
                            Array ay = (a.ShareToUser).Split(',');
                            foreach (var b in ay)
                            {
                                if (b.Equals(""))
                                {
                                    continue;
                                }
                                else
                                {
                                    int c = Convert.ToInt32(b);
                                    if (c == userID)
                                    {
                                        sfon.Add(a);
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                #endregion

               var iemsfon = sfon.OrderByDescending<ShareFileOrNotice, DateTime?>(u => u.UploadFileTime).Skip<ShareFileOrNotice>((pageIndex - 1) * pageSize).Take<ShareFileOrNotice>(pageSize);
                sfon = iemsfon.ToList();
                List<Sfob> rtsfob = new List<Sfob>();
                foreach (var Sf in sfon)
                {
                    Sfob s = new Sfob();
                    s.ID = Sf.ID;
                    s.ShareType =Sf.ShareType;
                    s.FileType = Sf.FileType;
                    s.BeiZhu = Sf.BeiZhu;
                    s.FileURL = Sf.FileURL;
                    s.UploadFileTime = Sf.UploadFileTime;
                    s.UserInfo = Sf.UserInfo;
                    s.ShareToUser = Sf.ShareToUser;
                    
                    string eyy = Sf.ShareToUser;
                    var usp= eyy.Split(',');
                    string lname=string.Empty;
                    foreach (var u in usp) {
                        if (u.Length <= 0)
                        {
                            continue;
                        }
                        int uid = Convert.ToInt32(u);
                       lname=lname+ UserInfoService.LoadEntities(x => x.ID == uid).FirstOrDefault().PerSonName+",";
                    }
                    s.alluserinfo = lname;
                    rtsfob.Add(s);
                }

                var Rtmp = from d in rtsfob
                           select new
                           {
                               ID = d.ID,
                               TypeID = d.ShareType.Name,
                               FileTypeID = d.FileType.FileTypeCHNName,
                               BeiZhu = d.BeiZhu,
                               FileURL = d.FileURL,
                               UploadFileTime = d.UploadFileTime,
                               ShareUser = d.UserInfo.PerSonName,
                               Sunv = d.ShareToUser,
                               alluserinfo = d.alluserinfo,
                               AddFile = d.UserInfo.ID,
                               shareuserid=LoginUser.ID
                           };
                

                return Json(new { rows = Rtmp, total = TotalCount }, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }
        //获取公告通知
        public ActionResult GetNotice()
        {
            int userID = LoginUser.ID;
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ID > 0).DefaultIfEmpty().ToList();
            List<ShareFileOrNotice> sfon = new List<ShareFileOrNotice>();
            if (temp[0] != null)
            {
                foreach (var a in temp)
                {
                    if (a.TypeID == 2) {
                        if (a.ShareUser == userID)
                        {
                            sfon.Add(a);
                            continue;
                        }
                        else
                        {
                            Array ay = (a.ShareToUser).Split(',');
                            foreach (var b in ay)
                            {
                                if (b.Equals(""))
                                {
                                    continue;
                                }
                                else
                                {
                                    int c = Convert.ToInt32(b);
                                    if (c == userID)
                                    {
                                        sfon.Add(a);
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                var Rtmp = from d in sfon
                           select new
                           {
                               ID = d.ID,
                               TypeID = d.ShareType.Name,
                               NoticeText = d.BeiZhu,
                               UpNoticeTime = d.UploadFileTime,
                               NoticeUser = d.UserInfo.PerSonName
                           };
                return Json(Rtmp, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }
        //获取通知全部内容
        public ActionResult GetNoticeAllText()
        {
            int id = Convert.ToInt32(Request["id"]);
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ID == id).FirstOrDefault();
            string beizhu = temp.BeiZhu;
            return Json(beizhu,JsonRequestBehavior.AllowGet);
        }
        //获取当前用户所有模型
        public ActionResult GetAllModel()
        {
            var uid = LoginUser.ID;
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ShareUser == uid && x.TypeID == 1).DefaultIfEmpty().ToList();
            List<ModelSF> list = new List<ModelSF>();
            if (temp.Count != 0 && temp[0] != null)
            {
                foreach (var a in temp)
                {
                    if (list.Count != 0)
                    {
                        int g = 0;
                        if (a == null || a.ModelList == "")
                        {
                            continue;
                        }
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == null)
                            {
                                continue;
                            }
                            if (a.ModelList == list[i].StrID)
                            {
                                g = 1;
                            }
                        }
                        if (g == 1)
                        {
                            continue;
                        }
                        ModelSF msf = new ModelSF();
                        msf.StrID = a.ModelList;
                        var str = (a.ModelList).Split(',');
                        var strs = "";
                        foreach (var c in str)
                        {
                            if (c == "")
                            {
                                continue;
                            }
                            var b1 = Convert.ToInt32(c);
                            var u = UserInfoService.LoadEntities(x => x.ID == b1).FirstOrDefault();
                            strs = strs + u.PerSonName + ",";
                        }
                        msf.StrName = strs;
                        list.Add(msf);
                    }
                    else
                    {
                        if (a == null || a.ModelList == "")
                        {
                            continue;
                        }
                        ModelSF msf = new ModelSF();
                        msf.StrID = a.ModelList;
                        var str = (a.ModelList).Split(',');
                        var strs = "";
                        foreach (var b in str)
                        {
                            if (b == "")
                            {
                                continue;
                            }
                            var b1 = Convert.ToInt32(b);
                            var u = UserInfoService.LoadEntities(x => x.ID == b1).FirstOrDefault();
                            strs = strs + u.PerSonName + ",";
                        }
                        msf.StrName = strs;
                        list.Add(msf);
                    }
                }
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        //获取用户模板
        public ActionResult GetModels()
        {
            var uid = LoginUser.ID;
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ShareUser == uid && (x.ModelList != null||x.ModelList != "")).DefaultIfEmpty().ToList();
            if (temp[0] == null)
            {
                return Json(new { ret = "no" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { ret = "ok" }, JsonRequestBehavior.AllowGet);
            }
        }
        //添加共享文件
        public ActionResult AddShareFile(ShareFileOrNotice sfon)
        {
            sfon.ShareUser = LoginUser.ID;
            sfon.ShareToUser = Request["STUstrName"];
            sfon.FileURL = Request["fileUrlName"];
            sfon.UploadFileTime = DateTime.Now;
            sfon.TypeID = 1;
            sfon.ModelList = Request["STUstrName"];
            ShareFileOrNotice sn = ShareFileOrNoticeService.AddEntity(sfon);
            return Json(new { ret = "ok" ,temp=sn}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getNewFileInfo()
        {
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ShareUser == LoginUser.ID).DefaultIfEmpty().OrderByDescending(x=>x.UploadFileTime).ToList();
            STUBuMen sm = new STUBuMen();
            sm.ID = temp[0].ID;
            sm.Name = temp[0].ShareToUser;
            return Json(sm, JsonRequestBehavior.AllowGet);
        }
        //补充上传共享文件
        public ActionResult AddUploadFile()
        {
            var sfid = Convert.ToInt64(Request["sfid"]);
            var sfurl = Request["sfurl"];
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ID == sfid).FirstOrDefault();
            if(temp != null)
            {
                temp.FileURL += ","+sfurl;
            }
            ShareFileOrNoticeService.EditEntity(temp);
            return Json(new { ret = "ok" }, JsonRequestBehavior.AllowGet);
        }
        //添加通知公告
        public ActionResult AddNotice(ShareFileOrNotice sfon)
        {
            sfon.ShareUser = LoginUser.ID;
            sfon.ShareToUser = Request["NoticestrName"]; 
            sfon.BeiZhu = Request["NoticeText"];
            sfon.UploadFileTime = DateTime.Now;
            sfon.TypeID = 2;
            var sn = ShareFileOrNoticeService.AddEntity(sfon);
            return Json(new { ret = "ok" }, JsonRequestBehavior.AllowGet);
        }
        //获取上传文件
        public ActionResult FileUpload()
        {
            HttpPostedFileBase file = Request.Files["uploadShareFileName"];
            if (file != null)
            {
                string filename = Path.GetFileName(file.FileName);//获取上传的文件名
                string fileExt = Path.GetExtension(filename);//获取扩展名
                var temp = FileTypeService.LoadEntities(x => x.ID > 0).DefaultIfEmpty().ToList();
                for (int a = 0; a < temp.Count(); a++)
                {
                    if (fileExt == temp[a].FileTypeENGName)
                    {
                        string dir = "/files/ShareFiles/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                        Directory.CreateDirectory(Path.GetDirectoryName(Request.MapPath(dir)));
                        string filenewName = Guid.NewGuid().ToString();
                        string fulldir = dir + filenewName + fileExt;
                        file.SaveAs(Request.MapPath(fulldir));
                        return Content("yes:" + fulldir);
                    }
                    else
                    {
                        continue;
                    }
                }
                return Content("no:文件类型错误或不支持，文件扩展名错误！");
            }
            else
            {
                return Content("no:请选择文件再上传");
            }
        }
        //获取所有部门名称
        public ActionResult GetAllBuMen()
        {
            var temp = BumenInfoSetService.LoadEntities(x => x.ID > 0).DefaultIfEmpty().ToList();
            List<STUBuMen> list = new List<STUBuMen>();
            foreach(var a in temp)
            {
                if (a == null)
                {
                    continue;
                }
                STUBuMen stubm = new STUBuMen();
                stubm.ID = a.ID;
                stubm.Name = a.Name;
                list.Add(stubm);
            }
            return Json(list,JsonRequestBehavior.AllowGet);
        }
        //获取部门用户名字
        public ActionResult GetShareToUser()
        {
            if (Request["BMID"].Length <= 0)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            var bmid = Convert.ToInt32(Request["BMID"]);
            var temp = UserInfoService.LoadEntities(x => x.BuMenID == bmid).DefaultIfEmpty().ToList();
            if (temp[0] != null)
            {
                List<BMUser> list = new List<BMUser>();
                foreach (var a in temp)
                {
                    if (a == null)
                    {
                        continue;
                    }
                    BMUser bmu = new BMUser();
                    bmu.ID = a.ID;
                    bmu.Name = a.PerSonName;
                    list.Add(bmu);
                }
                return Json(list, JsonRequestBehavior.AllowGet);
            }else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        //获取允许查看的用户ID
        public ActionResult ReturnUserID()
        {
            string uname = Request["personName"];
            int bmid = Convert.ToInt32(Request["BMID"]);
            var temp = UserInfoService.LoadEntities(x => x.PerSonName == uname && x.BuMenID == bmid).FirstOrDefault();
            if(temp == null){
                return Json(new { ret = "no"}, JsonRequestBehavior.AllowGet);
            }
            else
            {
                int a = temp.ID;
                return Json(new { ret = "ok",val = a}, JsonRequestBehavior.AllowGet);
            }
        }
        //获取所有文件类型
        public ActionResult GetAllFileType()
        {
            var temp = FileTypeService.LoadEntities(x => x.ID > 0).DefaultIfEmpty().ToList();
            List<FileTP> list = new List<FileTP>();
            foreach (var a in temp)
            {
                if (a == null)
                {
                    continue;
                }
                FileTP ftp = new FileTP();
                ftp.ID = a.ID;
                ftp.Name = a.FileTypeCHNName;
                list.Add(ftp);
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        //删除共享文件
        public ActionResult DelShareFile()
        {
            var uid = LoginUser.ID;
            var id = Convert.ToInt32(Request["id"]);
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ID == id).FirstOrDefault();
            if (temp == null)
            { return Json(new { msg = "数据库中无要修改的信息！" }, JsonRequestBehavior.AllowGet); }
            else
            {
                if (temp.ShareUser == uid) {
                    if (ShareFileOrNoticeService.DeleteEntity(temp))
                    {
                        int type = temp.TypeID;
                        if (type == 1)
                        {
                            string[] str = temp.FileURL.Split(',');
                            var list = str.ToList();
                            if (list != null)
                            {
                                foreach (var a in list)
                                {
                                    if (a != "")
                                    {
                                        if (Directory.Exists(Path.GetDirectoryName(Request.MapPath(a))))
                                        {
                                            System.IO.File.Delete(Request.MapPath(a));
                                        }
                                    }
                                }
                            }
                        }
                        return Json(new { ret = "ok" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { msg = "操作错误，没有删除成功！" }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { msg = "操作错误，你没有权限删除此信息！" }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        //获取文件下载路径
        public ActionResult GetFileUrl()
        {
            var id = Convert.ToInt32(Request["id"]);
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ID == id).FirstOrDefault();
            var url = temp.FileURL;
            var beizhu = temp.BeiZhu;
            return Json(new { ret = url,sbeizhu = beizhu},JsonRequestBehavior.AllowGet);
        }

        //获取全部用户id
        public ActionResult GetAllUserID()
        {
            var temp = UserInfoService.LoadEntities(x => x.ID > 0).DefaultIfEmpty().ToList();
            string str = null;
            foreach(var a in temp)
            {
                if (a == null)
                {
                    continue;
                }
                str = str +a.ID+",";
            }
            return Json(str,JsonRequestBehavior.AllowGet);
        }

        //获取部门下全部用户id
        public ActionResult ReturnAllUserID()
        {
            int bmid = Convert.ToInt32(Request["BuMenID"]);
            var temp = UserInfoService.LoadEntities(x => x.BuMenID == bmid).DefaultIfEmpty().ToList();
            if (temp[0] != null)
            {
                string str = null;
                foreach (var a in temp)
                {
                    if (a == null)
                    {
                        continue;
                    }
                    str = str + a.ID + ",";
                }
                return Json(new { ret = "ok",data = str }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { ret = "no" }, JsonRequestBehavior.AllowGet);
        }

        //查询是否有权补充文件
        public ActionResult GetCanOrCant()
        {
            var id = Convert.ToInt64(Request["id"]);
            var temp = ShareFileOrNoticeService.LoadEntities(x => x.ID == id).FirstOrDefault();
            if(temp != null)
            {
                if (temp.ShareUser != LoginUser.ID)
                {
                    return Json(new { ret = "no"},JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { ret = "ok" }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return null;
            }
        }

        //删除上传过程中的废弃文件
        public void DelLaJiFile()
        {
            var urlstr = Request["urlstr"];
            string[] str = urlstr.Split(',');
            var list = str.ToList();
            if (list != null)
            {
                foreach(var a in list)
                {
                    if(a != "")
                    {
                        if (Directory.Exists(Path.GetDirectoryName(Request.MapPath(a))))
                        {
                            System.IO.File.Delete(Request.MapPath(a));
                        }
                    }
                }
            }
        }

        public class STUBuMen
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public class BMUser
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public class FileTP
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public class ModelSF
        {
            public String StrID { get; set; }
            public string StrName { get; set; }
        }
    }
}
