using CRUD_Api.Models;
using CRUD_ClassLibrary.ClassLibrary;
using CRUD_DAL.DataLayer;
using CRUD_Solution.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Solution.CommonHelper
{
    public class HelperClass
    {
        private static HttpClient client = new HttpClient();
        public static void GetClient()
        {
            try
            {
                client = new HttpClient();
                string appURL = ConfigurationManager.AppSettings[WebConstant.APPURL].ToString();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(appURL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static async Task PushContactDetails(ContactRequest contactRequestObj)
        {
            try
            {
                GetClient();
                HttpResponseMessage responseObj = await client.PostAsJsonAsync(WebConstant.APIINSERT, contactRequestObj);
                responseObj.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<IList<ContactResponse>> GetContactDetails()
        {
            try
            {
                GetClient();
                List<ContactResponse> contactResponseListObj = new List<ContactResponse>();
                HttpResponseMessage responseObj = await client.GetAsync(WebConstant.APIGETCONTACTS);
                var ContactResponse = responseObj.Content.ReadAsStringAsync().Result;
                contactResponseListObj = JsonConvert.DeserializeObject<List<ContactResponse>>(ContactResponse);
                return contactResponseListObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<List<ContactResponse>> GetOneContactDetails(int ID)
        {
            try
            {
                GetClient();
                List<ContactResponse> contactResponseObj = new List<ContactResponse>();
                string path = WebConstant.APIGETONECONTACT + "/" + ID;
                HttpResponseMessage responseObj = await client.PostAsJsonAsync(path, ID);
                var contactResponseVar = responseObj.Content.ReadAsStringAsync().Result;
                contactResponseObj = JsonConvert.DeserializeObject<List<ContactResponse>>(contactResponseVar);
                return contactResponseObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<ContactResponse> UpdateOneContactDetails(ContactRequest contactRequestObj)
        {
            try
            {
                GetClient();
                ContactResponse ContactResponseObj = new ContactResponse();
                HttpResponseMessage responseObj = await client.PostAsJsonAsync(WebConstant.APIUPDATECONTACTS, contactRequestObj);
                var ContactResponse = responseObj.Content.ReadAsStringAsync().Result;
                ContactResponseObj = JsonConvert.DeserializeObject<ContactResponse>(ContactResponse);
                return ContactResponseObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<ContactResponse> DeleteContact(int ID)
        {
            try
            {
                GetClient();
                ContactResponse ContactResponseObj = new ContactResponse();
                string path = WebConstant.APIDELETECONTACTS + "/" + ID;
                HttpResponseMessage responseObj = await client.PostAsJsonAsync(path, ID);
                var ContactResponse = responseObj.Content.ReadAsStringAsync().Result;
                ContactResponseObj = JsonConvert.DeserializeObject<ContactResponse>(ContactResponse);
                return ContactResponseObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
