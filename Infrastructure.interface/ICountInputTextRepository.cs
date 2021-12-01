using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interface
{
    public interface ICountInputTextRepository
    {
        Array GetNumberTimesRepeatInputText(InputText inputText);
    }
}
