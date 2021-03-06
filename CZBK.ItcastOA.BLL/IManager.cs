﻿ 
using CZBK.ItcastOA.IBLL;
using CZBK.ItcastOA.Model;
using CZBK.ItcastOA.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.ItcastOA.BLL
{
	
	public partial class ActionInfoService :BaseService<ActionInfo>,IActionInfoService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.ActionInfoDal;
        }
    }   
	
	public partial class BumenInfoSetService :BaseService<BumenInfoSet>,IBumenInfoSetService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.BumenInfoSetDal;
        }
    }   
	
	public partial class CarNumberService :BaseService<CarNumber>,ICarNumberService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.CarNumberDal;
        }
    }   
	
	public partial class DepartmentService :BaseService<Department>,IDepartmentService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.DepartmentDal;
        }
    }   
	
	public partial class ExamineScheduleService :BaseService<ExamineSchedule>,IExamineScheduleService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.ExamineScheduleDal;
        }
    }   
	
	public partial class FileItemService :BaseService<FileItem>,IFileItemService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.FileItemDal;
        }
    }   
	
	public partial class FileTypeService :BaseService<FileType>,IFileTypeService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.FileTypeDal;
        }
    }   
	
	public partial class GongLuBaoXiaoBillService :BaseService<GongLuBaoXiaoBill>,IGongLuBaoXiaoBillService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.GongLuBaoXiaoBillDal;
        }
    }   
	
	public partial class Login_listService :BaseService<Login_list>,ILogin_listService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.Login_listDal;
        }
    }   
	
	public partial class R_UserInfo_ActionInfoService :BaseService<R_UserInfo_ActionInfo>,IR_UserInfo_ActionInfoService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.R_UserInfo_ActionInfoDal;
        }
    }   
	
	public partial class RoleInfoService :BaseService<RoleInfo>,IRoleInfoService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.RoleInfoDal;
        }
    }   
	
	public partial class ScheduleService :BaseService<Schedule>,IScheduleService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.ScheduleDal;
        }
    }   
	
	public partial class ScheduleTypeService :BaseService<ScheduleType>,IScheduleTypeService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.ScheduleTypeDal;
        }
    }   
	
	public partial class ScheduleUserService :BaseService<ScheduleUser>,IScheduleUserService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.ScheduleUserDal;
        }
    }   
	
	public partial class Seb_NumberService :BaseService<Seb_Number>,ISeb_NumberService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.Seb_NumberDal;
        }
    }   
	
	public partial class ShareFileOrNoticeService :BaseService<ShareFileOrNotice>,IShareFileOrNoticeService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.ShareFileOrNoticeDal;
        }
    }   
	
	public partial class ShareTypeService :BaseService<ShareType>,IShareTypeService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.ShareTypeDal;
        }
    }   
	
	public partial class sysdiagramService :BaseService<sysdiagram>,IsysdiagramService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.sysdiagramDal;
        }
    }   
	
	public partial class SysFieldService :BaseService<SysField>,ISysFieldService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.SysFieldDal;
        }
    }   
	
	public partial class T_BaojiaItemIDService :BaseService<T_BaojiaItemID>,IT_BaojiaItemIDService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_BaojiaItemIDDal;
        }
    }   
	
	public partial class T_BaoJiaToPService :BaseService<T_BaoJiaToP>,IT_BaoJiaToPService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_BaoJiaToPDal;
        }
    }   
	
	public partial class T_BaoXiaoBillService :BaseService<T_BaoXiaoBill>,IT_BaoXiaoBillService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_BaoXiaoBillDal;
        }
    }   
	
	public partial class T_BaoxiaoItemsService :BaseService<T_BaoxiaoItems>,IT_BaoxiaoItemsService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_BaoxiaoItemsDal;
        }
    }   
	
	public partial class T_BoolItemService :BaseService<T_BoolItem>,IT_BoolItemService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_BoolItemDal;
        }
    }   
	
	public partial class T_CanPanService :BaseService<T_CanPan>,IT_CanPanService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_CanPanDal;
        }
    }   
	
	public partial class T_ChanPinNameService :BaseService<T_ChanPinName>,IT_ChanPinNameService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_ChanPinNameDal;
        }
    }   
	
	public partial class T_CSC_CardService :BaseService<T_CSC_Card>,IT_CSC_CardService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_CSC_CardDal;
        }
    }   
	
	public partial class T_jgzztjbService :BaseService<T_jgzztjb>,IT_jgzztjbService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_jgzztjbDal;
        }
    }   
	
	public partial class T_JieKuanBillService :BaseService<T_JieKuanBill>,IT_JieKuanBillService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_JieKuanBillDal;
        }
    }   
	
	public partial class T_jxzztjbService :BaseService<T_jxzztjb>,IT_jxzztjbService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_jxzztjbDal;
        }
    }   
	
	public partial class T_SCCJService :BaseService<T_SCCJ>,IT_SCCJService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_SCCJDal;
        }
    }   
	
	public partial class T_SczzDanjuService :BaseService<T_SczzDanju>,IT_SczzDanjuService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_SczzDanjuDal;
        }
    }   
	
	public partial class T_SczzItemService :BaseService<T_SczzItem>,IT_SczzItemService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_SczzItemDal;
        }
    }   
	
	public partial class T_ShengChanZhiZhaoTopNameService :BaseService<T_ShengChanZhiZhaoTopName>,IT_ShengChanZhiZhaoTopNameService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_ShengChanZhiZhaoTopNameDal;
        }
    }   
	
	public partial class T_WinBakService :BaseService<T_WinBak>,IT_WinBakService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_WinBakDal;
        }
    }   
	
	public partial class T_WinBakFaHuoService :BaseService<T_WinBakFaHuo>,IT_WinBakFaHuoService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_WinBakFaHuoDal;
        }
    }   
	
	public partial class T_YSItemsService :BaseService<T_YSItems>,IT_YSItemsService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_YSItemsDal;
        }
    }   
	
	public partial class T_YXbj_masterService :BaseService<T_YXbj_master>,IT_YXbj_masterService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_YXbj_masterDal;
        }
    }   
	
	public partial class T_ZhiPiaoTongService :BaseService<T_ZhiPiaoTong>,IT_ZhiPiaoTongService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.T_ZhiPiaoTongDal;
        }
    }   
	
	public partial class User_Person_sltService :BaseService<User_Person_slt>,IUser_Person_sltService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.User_Person_sltDal;
        }
    }   
	
	public partial class UserbakService :BaseService<Userbak>,IUserbakService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.UserbakDal;
        }
    }   
	
	public partial class UserInfoService :BaseService<UserInfo>,IUserInfoService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.UserInfoDal;
        }
    }   
	
	public partial class WXX_FormIDService :BaseService<WXX_FormID>,IWXX_FormIDService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.WXX_FormIDDal;
        }
    }   
	
	public partial class WXXBaoJiaQuanXianService :BaseService<WXXBaoJiaQuanXian>,IWXXBaoJiaQuanXianService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.WXXBaoJiaQuanXianDal;
        }
    }   
	
	public partial class WXXMenuInfoService :BaseService<WXXMenuInfo>,IWXXMenuInfoService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.WXXMenuInfoDal;
        }
    }   
	
	public partial class WXXPhoneNumService :BaseService<WXXPhoneNum>,IWXXPhoneNumService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.WXXPhoneNumDal;
        }
    }   
	
	public partial class WXXScoreInfoService :BaseService<WXXScoreInfo>,IWXXScoreInfoService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.WXXScoreInfoDal;
        }
    }   
	
	public partial class WXXScoreUserService :BaseService<WXXScoreUser>,IWXXScoreUserService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.WXXScoreUserDal;
        }
    }   
	
	public partial class WXXUserInfoService :BaseService<WXXUserInfo>,IWXXUserInfoService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.WXXUserInfoDal;
        }
    }   
	
	public partial class YJ_ScheduleActionService :BaseService<YJ_ScheduleAction>,IYJ_ScheduleActionService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.YJ_ScheduleActionDal;
        }
    }   
	
	public partial class YJ_ScheduleDayService :BaseService<YJ_ScheduleDay>,IYJ_ScheduleDayService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.YJ_ScheduleDayDal;
        }
    }   
	
	public partial class YSGPmoneyService :BaseService<YSGPmoney>,IYSGPmoneyService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.YSGPmoneyDal;
        }
    }   
	
	public partial class YSGPtopService :BaseService<YSGPtop>,IYSGPtopService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.YSGPtopDal;
        }
    }   
	
	public partial class YXB_BaojiaService :BaseService<YXB_Baojia>,IYXB_BaojiaService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.YXB_BaojiaDal;
        }
    }   
	
	public partial class YXB_BaoJiaEidtMoneyService :BaseService<YXB_BaoJiaEidtMoney>,IYXB_BaoJiaEidtMoneyService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.YXB_BaoJiaEidtMoneyDal;
        }
    }   
	
	public partial class YXB_Kh_listService :BaseService<YXB_Kh_list>,IYXB_Kh_listService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.YXB_Kh_listDal;
        }
    }   
	
	public partial class YXB_WinCanPinService :BaseService<YXB_WinCanPin>,IYXB_WinCanPinService
    {
        public override void SetCurretnDal()
        {
            CurrentDal = this.GetCurrentDbSession.YXB_WinCanPinDal;
        }
    }   
	
}