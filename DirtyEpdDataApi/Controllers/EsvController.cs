using System;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DirtyEpdDataApi.Controllers
{
    public class EsvController : ApiController
    {
        // GET api/etrn
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public HttpResponseMessage Get()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MintransID", typeof(Guid));

            
            dt.Rows.Add(
                "19017c0e-3db2-4c8b-8fdc-9f3c09ebd2f2"
            ); 
            dt.Rows.Add(
                "9c824d48-2300-42f0-bd73-33628dae3aa9"

            ); 
            dt.Rows.Add(
                "2344f825-dc80-44a7-b2a9-cd1ea007ab55"
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