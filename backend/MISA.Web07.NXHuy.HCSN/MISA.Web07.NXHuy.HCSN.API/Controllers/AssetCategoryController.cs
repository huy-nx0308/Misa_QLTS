using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;
using MISA.HCSN.Common.Entities;

namespace MISA.Web07.NXHuy.HCSN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetCategoryController : ControllerBase
    {
        /// <summary>
        /// Lấy toàn bộ thông tin các loại tài sản
        /// </summary>
        [HttpGet]
        public IActionResult get()
        {
            try
            {
                //1 Khai báo kết nối
                var connectionString = "Host=localhost;Database=misa.web07.qlts;port=3306;User Id=root;password=123456@";

                //2 Kết nối tới MySql
                var sqlConnection = new MySqlConnection(connectionString);

                //3 Lấy dữ liệu
                var sqlCommand = "SELECT  FixedAssetCategoryId, FixedAssetCategoryCode, FixedAssetCategoryName FROM assetcategory";
                var assetCategory = sqlConnection.Query<object>(sql: sqlCommand);

                return Ok(assetCategory);

            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
            
        }
        private IActionResult HandleException(Exception ex)
        {
            var error = new ErrorService();
            return StatusCode(500, error);
        }
    }
}
