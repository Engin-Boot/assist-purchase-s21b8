using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AssetToPurchaseFrontend;
using AssetToPurchaseFrontend.Model;


namespace Asset_To_Purchase_FrontEnd.Tests
{
   //public class ClientRequestTests
   // {
   //    // private readonly UtilityFunctions _utilityFunction = new UtilityFunctions();
   //     ClientRequests clientReqeust = new ClientRequests();
   //     MonitoringDevice _device = new MonitoringDevice()
   //     {
   //         DeviceName1 = "IntelliVue X3",
   //         Ecg1 = "NO",
   //         Spo21 = "YES",
   //         Respiration1 = "YES",
   //         Hr1 = "YES",
   //         PhysiologicalAlarming1 = "NO",
   //         BloodPressure1 = "NO",
   //         BatteryLife1 = "8 in",
   //         SupportedScreenOrientations1 = "0° / 90° / 180°",
   //         Size1 = "249 x 97 x 121 mm",
   //         MobileOrStatic1 = "MOBILE",
   //         AntiMicrobialGlass1 = "YES",
   //         PatientLocation1 = "NO"
   //     };

   //     UserDetails _user = new UserDetails()
   //     {
   //         UserName1 = "XYZ",
   //         UserContactNo1 = 4561,
   //         ProductsBooked1 = "Philips"
   //     };
   //     [Fact]
   //     public void ExecuteGetRequestTest()
   //     {
   //         string url = "api/AlertUser/GetUserDetail/IntelliVue X3";
           
   //         var actualGetRequest = clientReqeust.ExecuteGetRequest(url);
   //         var expectedGetRequest = true;
   //         Assert.Equal(expectedGetRequest, actualGetRequest);
   //     }

   //     [Fact]
   //     public void ExecutePostRequestDeviceTest()
   //     {
   //         string url= "api/productcategory/PostDevice";
   //         var actualPostRequest = clientReqeust.ExecutePostRequest(url,_device);
   //         var expectedPostRequest = true;
   //         Assert.Equal(expectedPostRequest, actualPostRequest);
   //     }

   //     [Fact]
   //     public void ExecutePostRequestUserTest()
   //     {
   //         string url = "api/AlertUser/Registration";
   //         var actualPostRequestUser = clientReqeust.ExecutePostRequest(url, _user);
   //         var expectedPostRequestUser = true;
   //         Assert.Equal(expectedPostRequestUser, actualPostRequestUser);
   //     }

   //     [Fact]
   //     public void ExecuteDeleteRequestTest()
   //     {
   //         string url = "api/productcategory/devicename";
   //         var actualDeleteRequest = clientReqeust.ExecuteDeleteRequest(url);
   //         var expectedDeleteRequest = true;
   //         Assert.Equal(expectedDeleteRequest, actualDeleteRequest);
   //     }


   //     [Fact]
   //     public void ExecutePutRequestTest()
   //     {
   //         string url = "api/AlertUser/NewModelAlert";
   //         var actualPutRequest = clientReqeust.ExecutePutRequest(url);
   //         var expectedPutRequest = true;
   //         Assert.Equal(expectedPutRequest, actualPutRequest);
   //     }

   //     //[Fact]
   //     //public void ProductGetRequestTest()
   //     //{
   //     //    _utilityFunction.AddDevice(_device);
   //     //    string url = "api/productcategory";
   //     //    var actualProductGetRequest = clientReqeust.ProductGetRequest(url);
   //     //    Assert.True(actualProductGetRequest.Count > 0);
   //     //}

   //     //[Fact]
   //     //public void UserGetRequestTest()
   //     //{
   //     //    _utilityFunction.
   //     //    string url = "api/AlertUser";
   //     //    var actualUserGetRequest = clientReqeust.UserGetRequest(url);
   //     //    Assert.True(actualUserGetRequest.Count > 0);
   //     //}
   //     [Fact]
   //     public void ProductPostRequestTest()
   //     {
   //         string url = "api/productcategory/PostDevice";
   //         var actualProductPostRequest = clientReqeust.ProductPostRequest(url, _device);
   //         var expectedProductPostRequest = true;
   //         Assert.Equal(expectedProductPostRequest, actualProductPostRequest);
   //     }

   //     [Fact]
   //     public void ProductDeleteRequestTest()
   //     {
   //         string url = "api/productcategory/devicename";
   //         var actualProductDeleteRequest = clientReqeust.ProductDeleteRequest(url);
   //         var expectedProductDeleteRequest = true;
   //         Assert.Equal(expectedProductDeleteRequest, actualProductDeleteRequest);
   //     }

   //     [Fact]
   //     public void UserPostRequestTest()
   //     {
   //         string url = "api/AlertUser/Registration";
   //         var actualUserPostRequest = clientReqeust.UserPostRequest(url,_user);

   //         Assert.True(actualUserPostRequest.Count > 0);

   //     }
   // }
}
