﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using OpenAuth.Repository.Core;

namespace OpenAuth.Repository.Domain
{
    /// <summary>
	/// 入库通知单明细
	/// </summary>
    [Table("WmsInboundOrderDtbl")]
    public partial class WmsInboundOrderDtbl : Entity
    {
        public WmsInboundOrderDtbl()
        {
          this.AsnStatus= 0;
          this.GoodsId= string.Empty;
          this.GoodsBatch= string.Empty;
          this.QualityFlg= string.Empty;
          this.OrderNum= 0;
          this.InNum= 0;
          this.LeaveNum= 0;
          this.HoldNum= 0;
          this.ProdDate= string.Empty;
          this.ExpireDate= string.Empty;
          this.OwnerId= string.Empty;
          this.Remark= string.Empty;
          this.CreateTime= DateTime.Now;
          this.CreateUserId= string.Empty;
          this.CreateUserName= string.Empty;
          this.UpdateTime= DateTime.Now;
          this.UpdateUserId= string.Empty;
          this.UpdateUserName= string.Empty;
        }
        
        /// <summary>
        /// 订单ID
        /// </summary>
        [Description("订单ID")]
        [Browsable(false)]
        public string OrderId { get; set; }
        
        /// <summary>
        /// 含税单价
        /// </summary>
        [Description("含税单价")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 无税单价
        /// </summary>
        [Description("无税单价")]
        public decimal? PriceNoTax { get; set; }
        /// <summary>
        /// 是否收货中(0:非收货中,1:收货中)
        /// </summary>
        [Description("是否收货中")]
        public bool InStockStatus { get; set; }
        /// <summary>
        /// 到货状况(SYS_GOODSARRIVESTATUS)
        /// </summary>
        [Description("到货状况")]
        public int AsnStatus { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        [Description("商品编号")]
        [Browsable(false)]
        public string GoodsId { get; set; }
        /// <summary>
        /// 商品批号
        /// </summary>
        [Description("商品批号")]
        public string GoodsBatch { get; set; }
        /// <summary>
        /// 品质(SYS_QUALITYFLAG)
        /// </summary>
        [Description("品质")]
        public string QualityFlg { get; set; }
        /// <summary>
        /// 通知数量
        /// </summary>
        [Description("通知数")]
        public decimal OrderNum { get; set; }
        /// <summary>
        /// 到货数量
        /// </summary>
        [Description("到货数")]
        public decimal InNum { get; set; }
        /// <summary>
        /// 剩余数量
        /// </summary>
        [Description("剩余数")]
        public decimal LeaveNum { get; set; }
        /// <summary>
        /// 占用数量
        /// </summary>
        [Description("占用数")]
        [Browsable(false)]
        
        public decimal HoldNum { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        [Description("生产日期")]
        public string ProdDate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        [Description("失效日期")]
        public string ExpireDate { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        [Description("税率")]
        public decimal? TaxRate { get; set; }
        /// <summary>
        /// 货主编号
        /// </summary>
        [Description("货主编号")]
        [Browsable(false)]
        public string OwnerId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Description("备注")]
        [Browsable(false)]
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Description("创建时间")]
        public System.DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        [Description("创建人ID")]
        [Browsable(false)]
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Description("创建人")]
        public string CreateUserName { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Description("最后更新")]
        public System.DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 最后更新人ID
        /// </summary>
        [Description("最后更新人ID")]
        [Browsable(false)]
        public string UpdateUserId { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Description("最后更新人")]
        public string UpdateUserName { get; set; }
    }
}