using NameCreator.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameCreator.Service.Interface
{
    public interface IBasicProfileService
    {
        BaseResponseViewModel CreateProfile(BasicProfileRequestViewModel model);
        
    }
}
