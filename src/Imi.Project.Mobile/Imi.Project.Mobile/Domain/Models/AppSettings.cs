using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Models
{
    public class AppSettings
    {
        public Guid CurrentUserId { get; set; }
        public bool EnableLentOut { get; set; } //Het kunnen aangeven of je de film hebt uitgeleend
        public bool ChangeTheme { get; set; }

    }
}
