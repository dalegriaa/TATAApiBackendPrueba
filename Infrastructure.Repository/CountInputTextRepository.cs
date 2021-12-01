using Domain.Entity;
using Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Transaversal.common;

namespace Infrastructure.Repository
{
    public class CountInputTextRepository : ICountInputTextRepository
    {
        public Array GetNumberTimesRepeatInputText(InputText inputText)
        {
            return CountInputText.GetNumberTimesRepeatInputText(inputText.inputText);
        }
    }
}
