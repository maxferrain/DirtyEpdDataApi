using System;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DirtyEpdDataApi.Controllers
{
    public class EtrnController : ApiController
    {
        // GET api/etrn
        public HttpResponseMessage Get()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MintransID", typeof(Guid));
            dt.Columns.Add("DriverLicenceSeries", typeof(Int32));
            dt.Columns.Add("DriverLicenceNumber", typeof(Int32));
            dt.Columns.Add("GRZ");
            dt.Columns.Add("EtrnNum");
            dt.Columns.Add("RequestId", typeof(Guid));
            dt.Columns.Add("INN-natural", typeof(Int64));
            dt.Columns.Add("INN-legal-num", typeof(Int64));
            dt.Columns.Add("INN-legal-kpp", typeof(Int64));
            dt.Columns.Add("DateCreated", typeof(DateTime));
            dt.Columns.Add("ActiveStatus", typeof(Boolean));
            
            dt.Rows.Add(
                "19017c0e-3db2-4c8b-8fdc-9f3c09ebd2f2", 
                "7728", 
                "0896208", 
                "А 397 РВ 750", 
                "BB-102",
                "b30ce425-89e0-42b2-891a-dc166dc8780a", 
                "526317985689",
                "3254508555",
                "325401001",
                "11.12.2018"
            ); 
            dt.Rows.Add(
                "3e1cbf92-e834-4ac0-9a71-7e8f52949440", 
                null, 
                "258182",
                "H 643 BM 799", 
                "EE-286",
                "193b2fdf-b2ae-4060-a75b-38eed5a5b351", 
                null,
                "4829323313",
                "717511901",
                "07.23.2020",
                true
            ); 
            dt.Rows.Add(
                "9c824d48-2300-42f0-bd73-33628dae3aa9", 
                "5424", 
                "653738",
                "А 610 АХ 122", 
                "TA-915",
                "b038487c-c882-4eea-a2a3-1bc33aadf222", 
                "170388927875",
                "9259450233",
                "917459327",
                "01.12.2016",
                false
            ); 
            dt.Rows.Add(
                "2344f825-dc80-44a7-b2a9-cd1ea007ab55", 
                "9898",
                "437386", 
                "У 574 СТ 05", 
                "OP-275",
                "dcd3ba1f-b020-47bd-ab0d-34192b98b39c", 
                "991868630275",
                "1874025902",
                "112947150",
                "12.04.2017",
                true
            ); 
            dt.Rows.Add(
                "a4230d94-6a2a-4cac-9ebf-a68516a29923", 
                null, 
                "653738",
                "P 999 TT 12", 
                "TA-915",
                "49fc6d16-0123-427b-91bf-ee0520a930f0", 
                "562332014595",
                null,
                null,
                "10.12.2019",
                true
            ); 
            dt.Rows.Add(
                "ccbd7eea-06a6-4193-a309-35678b5c7b74", 
                "3863",
                "373428", 
                "T 264 OO 69", 
                "PP-119",
                "8458d713-60e7-44df-8c31-370a6dc6f6da", 
                "186062542836",
                "9773676362",
                "765832577",
                "02.01.2021",
                false
            ); 
            dt.Rows.Add(
                "0bcd65a3-a71a-4f2f-a422-ce74c4a9e664", 
                "9275",
                "382582", 
                "E 185 BB 777", 
                "CX-245",
                "e4a94971-228e-4f95-9b55-296cc2edef17", 
                "927871291279",
                "7469824173",
                "567038190",
                "06.21.2020",
                true
            ); 


            return Request.CreateResponse(HttpStatusCode.OK, dt);

            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}