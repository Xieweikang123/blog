﻿namespace Netnr.Login
{
    /// <summary>
    /// Step1：Oauth2/authorize 
    /// </summary>
    public class TaoBao_Authorize_RequestEntity
    {
        /// <summary>
        /// 授权类型 ，值为code。
        /// </summary>
        [Required]
        public string response_type { get; set; } = "code";

        /// <summary>
        /// 等同于appkey，创建应用时获得。
        /// </summary>
        [Required]
        public string client_id { get; set; } = TaoBaoConfig.AppKey;

        /// <summary>
        /// redirect_uri指的是应用发起请求时，所传的回调地址参数，在用户授权后应用会跳转至redirect_uri。
        /// 要求与应用注册时填写的回调地址域名一致或顶级域名一致 。
        /// </summary>
        [Required]
        public string redirect_uri { get; set; } = TaoBaoConfig.Redirect_Uri;

        /// <summary>
        /// 维持应用的状态，传入值与返回值保持一致。
        /// </summary>
        public string state { get; set; } = System.Guid.NewGuid().ToString("N");

        /// <summary>
        /// web,可选web、tmall或wap其中一种，默认为web。
        /// Web对应PC端（淘宝logo）浏览器页面样式；
        /// Tmall对应天猫的浏览器页面样式；
        /// Wap对应无线端的浏览器页面样式。
        /// </summary>
        public string view { get; set; } = "web";
    }
}