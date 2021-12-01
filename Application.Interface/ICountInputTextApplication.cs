using System;
using System.Collections.Generic;
using System.Text;
using Transversal.Common;

namespace Application.Interface
{
    public interface ICountInputTextApplication
    {
       Response<string> GetNumberTimesRepeatInputText(string inputTetx); 
    }
}
