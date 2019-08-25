﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZFS.Model.Entity;
using ZFS.Model.Query;

namespace ZFS.Model.RequestModel
{
    #region 查找/新增/更新/删除用户

    /// <summary>
    /// 用户登录
    /// </summary>
    public class UserLoginRequest : BaseRequest
    {
        public override string route { get { return ServerIP + "api/User/Login"; } }

        public string account { get; set; }

        public string passWord { get; set; }
    }

    public class UserLoginAuthRequest : BaseRequest
    {
        public override string route { get { return ServerIP + "api/User/Perm"; } }

        public string account { get; set; }
    }

    /// <summary>
    /// 查找用户
    /// </summary>
    public class UserQueryRequest : BaseRequest
    {

        public override string route { get { return ServerIP + "api/User/GetUser"; } }

        public UserParameters parameters { get; set; }
    }

    public class UserAeRequest : BaseRequest
    {
        public override string route { get { return ServerIP + "api/User"; } }

        public User Entity { get; set; }
    }

    public class UserDeleteRequest : BaseRequest
    {
        public override string route { get { return ServerIP + "api/User"; } }

        public Guid id { get; set; }
    }

    #endregion

}