using Domain.Entity;
using Domain.Interface;
using Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core
{
    public class CountInputTextDoimain : ICountInputTextDoimain
    {
        private readonly ICountInputTextRepository _countInputTextRepository;
       public CountInputTextDoimain(ICountInputTextRepository countInputTextRepository)
        {
            _countInputTextRepository = countInputTextRepository;
        }
        public Array GetNumberTimesRepeatInputText(InputText inputText)
        {
            return _countInputTextRepository.GetNumberTimesRepeatInputText(inputText);
        }
    }
}
