using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewItems
    {
        partial void CreateNewItems_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Добавьте сюда свой код.
            this.ItemsProperty = new Items();
        }

        partial void CreateNewItems_Saved()
        {
            // Добавьте сюда свой код.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.ItemsProperty);
        }
    }
}