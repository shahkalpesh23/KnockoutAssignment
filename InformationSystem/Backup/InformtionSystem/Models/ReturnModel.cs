using System.Collections.Generic;

namespace InformationSystem.Models
{
    public class ReturnModel
    {
        public List<Data> DataList { get; set; }
        public bool IsSessionValid { get; set; }
    }
}