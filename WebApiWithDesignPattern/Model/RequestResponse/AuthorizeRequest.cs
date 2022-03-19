namespace Model.RequestResponse
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class AuthorizeRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string StoreName { get; set; }
        public string DOB { get; set; }
    }
}
