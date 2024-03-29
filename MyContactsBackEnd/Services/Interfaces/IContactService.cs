﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Utils.Dtos.Contact;

namespace Services.Interfaces
{
    public interface IContactService
    {
        Task<bool> CreateAsync(ContactCreateRequestDto contactCreateDto);
        Task<List<ContactResponseDto>> GetAllByUserIdAsync(int userID);
        Task<bool> UpdateAsync(ContactUpdateRequestDto contactUpdateDto);
        Task<bool> DeleteAsync(int id);


    }
}
