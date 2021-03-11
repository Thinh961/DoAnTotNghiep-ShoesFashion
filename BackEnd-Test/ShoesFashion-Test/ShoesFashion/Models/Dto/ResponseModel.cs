using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Dto
{
    public class ResponseModel<T>
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public T Data;

        public ResponseModel()
        {
            Error = "";
            Message = "";
            Data = default(T);
        }
    }
}
