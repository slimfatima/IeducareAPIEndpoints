using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEduCare.Service
{
    public class ServiceBase
    {
        private readonly IMapper _mapper;
        
        public ServiceBase(string connectionString, IMapper mapper)
        {
            ConnectionString = connectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ApplicationException("Context connectionString value cannot be null or empty string");                
            }
            _mapper = mapper;
        }
        public string ConnectionString { get; set; }

        protected object Map<T>(object dataSource, T destination, Type sourceType, Type destinationType)
        {
            if (dataSource == null)
                return dataSource;
            try
            {
                return _mapper.Map(dataSource, destination, sourceType, destinationType);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
