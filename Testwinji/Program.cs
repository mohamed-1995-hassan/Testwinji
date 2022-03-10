using Microsoft.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Testwinji
{
    class Program
    {
        #region Token
        static string CookieBased = ".AspNetCore.Antiforgery.w5W7x28NAIs=" +
            "CfDJ8DFuPpreICtMmPI9Au-MszVe4Eiz0xZm--9" +
            "MlXr9OXAKvi3Mh0kFnTHP8kD_VhgDuDtphTQkfUqouvIx9yQqRZfBoJ" +
            "tkXRmdfPrPcMHMvU0sGyCh8jac3vVMvvI1mT_GzAkvVkyDO_RMkCdCTCw9g" +
            "BM; ARRAffinity=20fb944e0f1aaef5076bd8915b3ecc838cda0a8d731a413" +
            "18e2117dd461e1fe6; ARRAffinitySameSite=20fb944e0f1aaef5076bd8915b3" +
            "ecc838cda0a8d731a41318e" +
            "2117dd461e1fe6; _ga=GA1.3.1685070259.1646852207;" +
            " _gid=GA1.3.384219757.1646852207; __stripe_mid=dec9902e-e14f-422c-8a84-f8b10f3" +
            "6e534794a41; __stripe_sid=8772bd93-29ec-49ac-ad39-f6f26739a74b64eeab;" +
            " TrackingToken=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2NDY4N" +
            "zQ0ODMsImlzcyI6Imh0dHBzOi8veHdpbmppLXRyYWNraW5nLmF6dXJld2Vic2l0ZXMubmV" +
            "0IiwiYXVkIjoiaHR0cHM6Ly94d2luamkuYXp1cmV3ZWJzaXRlcy5uZXQifQ.KSm6_GrxNbwTF" +
            "y0srtcLEODQFxZbuObG2nWJgfHfAZQ; themeSettings=null; idsrv.session=0CF" +
            "BCEE488FD59B9A818BA387AA72E43; .AspNetCore.Identity.Application=CfDJ8DF" +
            "uPpreICtMmPI9Au-MszUPQVchBLcCAqAQgsv7QMgt7CeHcfnCtpbwdYrm2ff9OgdqXyDj2jc" +
            "6zFsZfiqC4OA9lSsqVkOncNyJt2rMpvwNuRaWudNdNdMexeCLuCk5ZXRWqDpKcpo0fqgWX" +
            "qRPQC1Gao26BT4hmt5wW4IN_4q1kk-vCJD_v6UMUHTyj7Co-NhyT-dPVPGxRX9fZ8bL56gJ" +
            "w6B88XyIhgtbW6OP-RC3hDTtuAYrnOLZBIXm-kBbFKeGohzGVJlQ-9mVkhi2oX9KKX5L" +
            "2Qz0JaojKBtQQd3Pj-CSOSWPHu-ugFd5wYaKNnEu_f_Al8yDYhKMSokzQxR_GXXp" +
            "qvXpsCUglhri2_x46O9qwWIoxZkSZFKsQdKG6W23_pF3M6kannqeuZP7yKTSNoPa" +
            "cE2O-56dmsQgXvL1uPO_DPouN8Rtifr1HLM8F-_m4q56D5xvaYQ2zNJrSXmQiJErGQ-" +
            "cNADAHC1CLsVabgCiJiXWQjtuW8Z2WNHMaLLbx4FwCDu5OKlD8qVaS04WO5z32nZpZMmc" +
            "j40kr-H-4MaRKAvHnWZrImVn3h7AWwBVtQNavTfjOur4DriBVuXD1HO8BBEDyXR-FsvvDH4" +
            "DgMGvZ8X4swe-x7_s9u-vusPC_Mi-DO3mPlj5AGKJPKSad4BG25k62aNOectGgx6QVIpmkoNsXa" +
            "CxEV-Ne8uE8kjsYPueXoFg-M2Zjl7KaVGQYArb7s-uOzmyxCgZMGJJyu4dLCz40Grjgd3dUPS2Tx" +
            "P6IepivhiOW7NW7yiuaoCD8nqgr98izlGEPCBj5LrWWwTSsa8WKUAvQ-CKRBJ_9KVYxqwWogjFTuP" +
            "9HIqAvjCosoWfA9W2SKmNQ_ZTrESVKKejlmTvzrqpyPyTdMeE9OV3dz-QtYbpZI2ZK2UyNeXMZ" +
            "K9EfeuKEZ0foEDp_M2Y7lZpSNTcIUmsoXcCAL4GjHF_mJR3veaNwmFApuLlqz95yUwZ2_ysfTVMP" +
            "3hgUReDwU5vnn4Rby_datgVNdBTvCL1SDdfMPeNNlIlzxvij3vF6QAy6H4fqBfDzteeA3q1;" +
            " CurentActiveUserId=33044; xsrf-token=CfDJ8DFuPpreICtMmPI9Au-MszXYuWZ6T0SE" +
            "-MDxWMKfUdghFqozcLQfpR7bAUlw-ZCb1DN5jEWmvM5qTh7QwynLp3a5xkk5pWYYxVRoIlvxeYOp" +
            "Dsa2BT26RWNRjRD4CCLPMMzXpr_UE07HLFcrMZ4a6TQNAlw_pPT67wKDEXj9uobGWhh7rTmN" +
            "2c6ClUM1ShorCg; _gat=1";
        #endregion
        static async Task Main(string[] args)
        {
            var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            "https://xwinji.azurewebsites.net/api/CourseApi/GetCourseDetailsAndUpdateLastAccess?courseGroupId=90915")
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
                { HeaderNames.Cookie, CookieBased },
            }
        };

            HttpClient HC = new HttpClient();
            var httpResponseMessage =await HC.SendAsync(httpRequestMessage);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream = await httpResponseMessage.Content.ReadAsStringAsync();
                var o = JObject.Parse(contentStream);
                course c = (course)o.ToObject(typeof(course));
                Console.WriteLine(c.SelectedCourseId);
            }
        }
    }

    class course
    {
        public string SelectedCourseId { get; set; }
        public string InstructorName { get; set; }
        public int StudentsCount { get; set; }
        public string CourseImageUrl { get; set; }
        public string InstructorProfilePictureUrlSmall { get; set; }
        public string InstructorId { get; set; }
        public int JoiningType { get; set; }
        public bool HasRequests { get; set; }
        public bool IsAutoAccept { get; set; }
        public double Rate { get; set; }
        public int Type { get; set; }
        public bool IsLearningPathsEnabled { get; set; }
        public string LearningPathTheme { get; set; }
        public bool IsShowLearnersProgress { get; set; }
        public int CourseRequestsCount { get; set; }
        public int Status { get; set; }
        public bool IsCourseGamificationEnabled { get; set; }
        public bool IsCertificateEnabled { get; set; }
        public bool IsVideoBased { get; set; }
        public bool IsCanPlayCourse { get; set; }
        public bool IsCanResumeCourse { get; set; }
        public bool IsPushed { get; set; }
        public bool IsEnableAttendance { get; set; }
        public bool IsProhibitJoinMultipleRounds { get; set; }
        public bool IsEnableGradebook { get; set; }
        public bool IsLearnerUser { get; set; }
        public bool ResetUserCourseCount { get; set; }
        public bool IsEnableDownloadMaterials { get; set; }
        public bool IsAdabtiveLearning { get; set; }

    }
}
