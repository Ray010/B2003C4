﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Web;
using Microsoft.JSInterop;
using B2003C4.Data;
using B2003C4.Class;
using System.Runtime.Serialization.Formatters.Binary;


namespace B2003C4.Pages
{
    public partial class Index
    {

        public string msg = "Index ->";

        [Inject]
        protected NavigationManager Navi { get; set; }
        
        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        //public string Bug = "<svg width='1em' height='1em' viewBox='0 0 16 16' class='Bug bi bi-bug' fill='currentColor' xmlns='http://www.w3.org/2000/svg'><path fill-rule='evenodd' d='M4.355.522a.5.5 0 0 1 .623.333l.291.956A4.979 4.979 0 0 1 8 1c1.007 0 1.946.298 2.731.811l.29-.956a.5.5 0 1 1 .957.29l-.41 1.352A4.985 4.985 0 0 1 13 6h.5a.5.5 0 0 0 .5-.5V5a.5.5 0 0 1 1 0v.5A1.5 1.5 0 0 1 13.5 7H13v1h1.5a.5.5 0 0 1 0 1H13v1h.5a1.5 1.5 0 0 1 1.5 1.5v.5a.5.5 0 1 1-1 0v-.5a.5.5 0 0 0-.5-.5H13a5 5 0 0 1-10 0h-.5a.5.5 0 0 0-.5.5v.5a.5.5 0 1 1-1 0v-.5A1.5 1.5 0 0 1 2.5 10H3V9H1.5a.5.5 0 0 1 0-1H3V7h-.5A1.5 1.5 0 0 1 1 5.5V5a.5.5 0 0 1 1 0v.5a.5.5 0 0 0 .5.5H3c0-1.364.547-2.601 1.432-3.503l-.41-1.352a.5.5 0 0 1 .333-.623zM4 7v4a4 4 0 0 0 3.5 3.97V7H4zm4.5 0v7.97A4 4 0 0 0 12 11V7H8.5zM12 6H4a3.99 3.99 0 0 1 1.333-2.982A3.983 3.983 0 0 1 8 2c1.025 0 1.959.385 2.666 1.018A3.989 3.989 0 0 1 12 6z' /></svg>";

        public FormSearchDataModel Base_CurrentPage;


        [Parameter]
        public FormSearchDataModel CurrentPage { get; set; }

        [Parameter]
        public EventCallback<FormSearchDataModel> CurrentPageChanged { get; set; }

        private FormSearchDataModel _currentPage;


        protected override void OnInitialized()
        {
            CurrentPage.Back_History.Add(CurrentPage.Deep_Copy());   //.Add(CurrentPage);
            if(CurrentPage.Back_History.Count >= 5)
            {
                Console.WriteLine("Dele");
                CurrentPage.Back_History.RemoveRange(0, 2);
            }
            CurrentPageChanged.InvokeAsync(CurrentPage);
        }

        void Up()
        {
            CurrentPage.S_DokusyaCode = CurrentPage.S_DokusyaCode + 1;
            CurrentPageChanged.InvokeAsync(CurrentPage);
            Console.WriteLine(msg + "UP" + _currentPage.IndexURL);
        }

        public async void JumpPage(string URLx)
        {
            CurrentPage.CurrentURL = CurrentPage.IndexURL;
            CurrentPage.IndexURL = URLx;
            CurrentPage.PhaseNo = 1;
            await CurrentPageChanged.InvokeAsync(CurrentPage);
                        
            StateHasChanged();
        }
    }
}


