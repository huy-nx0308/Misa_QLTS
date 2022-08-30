using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MISA.HCSN.Common.Entities
{
    public class Asset
    {
        /// <summary>
        /// Id tài sản
        /// </summary>
        [Key]
        public Guid FixedAssetId { get; set; }

        /// <summary>
        /// Mã tài sản
        /// </summary>
        public string FixedAssetCode { get; set; }

        /// <summary>
        /// Tên tài sản
        /// </summary>
        public string FixedAssetName { get; set; }

        /// <summary>
        ///Id bộ phận
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Mã bộ phận
        /// </summary>
        public string DepartmentCode { get; set; }

        /// <summary>
        /// Tên bộ phận
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Id loại tài sản
        /// </summary>
        public Guid FixedAssetCategoryId { get; set; }

        /// <summary>
        /// Mã loại tài sản
        /// </summary>
        public string FixedAssetCategoryCode { get; set; }

        /// <summary>
        /// Tên loại tài sản
        /// </summary>
        public string FixedAssetCategoryName { get; set; }

        /// <summary>
        /// ngày mua
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Nguyên giá
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Số lượng
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Tỉ lệ hao mòn
        /// </summary>
        public float DepreciationRate { get; set; }

        /// <summary>
        /// Ngày bắt đầu sử dụng
        /// </summary>
        public DateTime Productiondate { get; set; }


        /// <summary>
        /// Năm theo dõi
        /// </summary>

        public int TrackedYear { get; set; }

        /// <summary>
        /// Số năm sử dụng
        /// </summary>
        public int LifeTime { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        ///Ngày sửa       
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa
        /// </summary>
        public string ModifiedBy { get; set; }
    }
}
