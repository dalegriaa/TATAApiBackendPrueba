using Application.Dto;
using Application.Interface;
using Application.Main.Factories;
using AutoMapper;
using Domain.Entity;
using Domain.Interface;
using Newtonsoft.Json;
using System;
using Transversal.Common;

namespace Application.Main
{
    public class CountInputTextApplication : ICountInputTextApplication
    {
        private readonly IMapper _mapper;
        private readonly ICountInputTextDoimain _countInputTextDomain;
        public CountInputTextApplication(IMapper mapper, ICountInputTextDoimain countInputTextDomain)
        {
            _countInputTextDomain = countInputTextDomain;
            _mapper = mapper;
        }
        public Response<string> GetNumberTimesRepeatInputText(string inputText)
        {
            // esta entidad contiene toda la informacion del flujo de la app
            var response = new Response<string>();
            try
            {
                var inputTextDto = new InputTextDto();
                inputTextDto.inputText = inputText;
                var inputTextMapToEntity = _mapper.Map<InputText>(inputTextDto);
                Array numberTimesRepeatList = _countInputTextDomain.GetNumberTimesRepeatInputText(inputTextMapToEntity);
                string numberTimesRepeat = JsonConvert.SerializeObject(numberTimesRepeatList);
                response = ResponseFactory.GetReponse(numberTimesRepeat, true, "Succesful operation");

            }
            catch(Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
    }
}
