using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Helpers
{
    public class Pages
    {
        private Pages(string value) { Value = value; }

        public string Value { get; set; }

        //Dashboard
        public static Pages Dashboard1 { get { return new Pages("Dashboard1"); } }
        public static Pages Dashboard2 { get { return new Pages("Dashboard2"); } }
        public static Pages Dashboard3 { get { return new Pages("Dashboard3"); } }
        public static Pages Dashboard4 { get { return new Pages("Dashboard4"); } }
        public static Pages Dashboard5 { get { return new Pages("Dashboard5"); } }
        public static Pages Dashboard6 { get { return new Pages("Dashboard6"); } }

        //Page Layout
        public static Pages VerticalStatic { get { return new Pages("VerticalStatic"); } }
        public static Pages VerticalFixed { get { return new Pages("VerticalFixed"); } }
        public static Pages VerticalNavbarFixed { get { return new Pages("VerticalNavbarFixed"); } }
        public static Pages VerticalCollapseMenu { get { return new Pages("VerticalCollapseMenu"); } }      
        public static Pages LightLayout { get { return new Pages("LightLayout"); } }
        public static Pages DarkLayout { get { return new Pages("DarkLayout"); } }
        public static Pages ColorIcon { get { return new Pages("ColorIcon"); } }

        //Widget
        public static Pages Widget1 { get { return new Pages("Widget1"); } }
        public static Pages Widget2 { get { return new Pages("Widget2"); } }
        public static Pages Widget3 { get { return new Pages("Widget3"); } }
        public static Pages Widget4 { get { return new Pages("Widget4"); } }
        public static Pages Widget5 { get { return new Pages("Widget5"); } }
        public static Pages Widget6 { get { return new Pages("Widget6"); } }

        //UI Element Basic
        public static Pages Alert { get { return new Pages("Alert"); } }
        public static Pages Button { get { return new Pages("Button"); } }
        public static Pages Badges { get { return new Pages("Badges"); } }
        public static Pages Pagination { get { return new Pages("Pagination"); } }
        public static Pages Cards { get { return new Pages("Cards"); } }
        public static Pages Collapse { get { return new Pages("Collapse"); } }
        public static Pages Carousel { get { return new Pages("Carousel"); } }
        public static Pages GridSystem { get { return new Pages("GridSystem"); } }
        public static Pages Progress { get { return new Pages("Progress"); } }
        public static Pages Modal { get { return new Pages("Modal"); } }
        public static Pages Spinner { get { return new Pages("Spinner"); } }
        public static Pages Tabs { get { return new Pages("Tabs"); } }
        public static Pages Typography { get { return new Pages("Typography"); } }
        public static Pages Tooltip { get { return new Pages("Tooltip"); } }
        public static Pages Toasts { get { return new Pages("Toasts"); } }
        public static Pages Other { get { return new Pages("Other"); } }
        public static Pages BasicPackage { get { return new Pages("BasicPackage"); } }

        //UI Element Advance
        public static Pages SweetAlert { get { return new Pages("SweetAlert"); } }
        public static Pages Datepicker { get { return new Pages("Datepicker"); } }
        public static Pages Gridstack { get { return new Pages("Gridstack"); } }
        public static Pages Lightbox { get { return new Pages("Lightbox"); } }
        public static Pages AdvanceModal { get { return new Pages("AdvanceModal"); } }
        public static Pages Notification { get { return new Pages("Notification"); } }
        public static Pages Nestable { get { return new Pages("Nestable"); } }
        public static Pages Pnotify { get { return new Pages("Pnotify"); } }
        public static Pages Rating { get { return new Pages("Rating"); } }
        public static Pages Rangeslider { get { return new Pages("Rangeslider"); } }
        public static Pages Slider { get { return new Pages("Slider"); } }
        public static Pages Highlighter { get { return new Pages("Highlighter"); } }
        public static Pages Tour { get { return new Pages("Tour"); } }
        public static Pages TreeView { get { return new Pages("TreeView"); } }
        public static Pages Toolbar { get { return new Pages("Toolbar"); } }
        public static Pages AdvancePackage { get { return new Pages("AdvancePackage"); } }

        //Extra
        public static Pages Timeout { get { return new Pages("Timeout"); } }
        public static Pages Idle { get { return new Pages("Idle"); } }
        public static Pages Offline { get { return new Pages("Offline"); } }

        //Animations
        public static Pages Animation1 { get { return new Pages("Animation1"); } }

        //Icons
        public static Pages Feather { get { return new Pages("Feather"); } }
        public static Pages FontAwesome { get { return new Pages("FontAwesome"); } }
        public static Pages Flag { get { return new Pages("Flag"); } }
        public static Pages Material { get { return new Pages("Material"); } }
        public static Pages SimpleLine { get { return new Pages("SimpleLine"); } }
        public static Pages Themify { get { return new Pages("Themify"); } }

        //Forms
        public static Pages FormElements { get { return new Pages("FormElements"); } }
        public static Pages FormAdvance { get { return new Pages("FormAdvance"); } }
        public static Pages FormValidation { get { return new Pages("FormValidation"); } }
        public static Pages FormMasking { get { return new Pages("FormMasking"); } }
        public static Pages FormWizard { get { return new Pages("FormWizard"); } }
        public static Pages FormPicker { get { return new Pages("FormPicker"); } }
        public static Pages FormSelect { get { return new Pages("FormSelect"); } }

        //Table
        public static Pages Bootstrap { get { return new Pages("Bootstrap"); } }
        public static Pages Datatable { get { return new Pages("Datatable"); } }

        //Chart
        public static Pages AmChart { get { return new Pages("AmChart"); } }
        public static Pages ChartJS { get { return new Pages("ChartJS"); } }
        public static Pages EChart { get { return new Pages("EChart"); } }
        public static Pages Google { get { return new Pages("Google"); } }
        public static Pages Highchart { get { return new Pages("Highchart"); } }
        public static Pages Knob { get { return new Pages("Knob"); } }
        public static Pages Morris { get { return new Pages("Morris"); } }
        public static Pages Nvd3 { get { return new Pages("Nvd3"); } }
        public static Pages Peity { get { return new Pages("Peity"); } }
        public static Pages Radial { get { return new Pages("Radial"); } }
        public static Pages ChartPackage { get { return new Pages("ChartPackage"); } }

        //Maps
        public static Pages GoogleMap { get { return new Pages("GoogleMap"); } }
        public static Pages Vector { get { return new Pages("Vector"); } }
        public static Pages GMapSearch { get { return new Pages("GMapSearch"); } }

        //Pages Auth
        public static Pages SignUp { get { return new Pages("SignUp"); } }
        public static Pages SignUp2 { get { return new Pages("SignUp2"); } }
        public static Pages SignUp3 { get { return new Pages("SignUp3"); } }
        public static Pages SignUp4 { get { return new Pages("SignUp4"); } }
        public static Pages SignUp5 { get { return new Pages("SignUp5"); } }
        public static Pages SignIn { get { return new Pages("SignIn"); } }
        public static Pages SignIn2 { get { return new Pages("SignIn2"); } }
        public static Pages SignIn3 { get { return new Pages("SignIn3"); } }
        public static Pages SignIn4 { get { return new Pages("SignIn4"); } }
        public static Pages SignIn5 { get { return new Pages("SignIn5"); } }
        public static Pages ResetPassword { get { return new Pages("ResetPassword"); } }
        public static Pages ResetPassword2 { get { return new Pages("ResetPassword2"); } }
        public static Pages ResetPassword3 { get { return new Pages("ResetPassword3"); } }
        public static Pages ResetPassword4 { get { return new Pages("ResetPassword4"); } }
        public static Pages ResetPassword5 { get { return new Pages("ResetPassword5"); } }
        public static Pages ChangePassword { get { return new Pages("ChangePassword"); } }
        public static Pages PersonalInformation { get { return new Pages("PersonalInformation"); } }
        public static Pages ProfileSettings { get { return new Pages("ProfileSettings"); } }
        public static Pages MapForm { get { return new Pages("MapForm"); } }
        public static Pages Subscribe { get { return new Pages("Subscribe"); } }

        //Maintenance
        public static Pages Error { get { return new Pages("Error"); } }
        public static Pages ComingSoon { get { return new Pages("ComingSoon"); } }
        public static Pages OfflineUI { get { return new Pages("OfflineUI"); } }

        //App Message
        public static Pages Message { get { return new Pages("Message"); } }

        //App Task
        public static Pages TaskList { get { return new Pages("TaskList"); } }
        public static Pages TaskBoard { get { return new Pages("TaskBoard"); } }
        public static Pages TaskDetail { get { return new Pages("TaskDetail"); } }

        //App Todo
        public static Pages Todo { get { return new Pages("Todo"); } }
        public static Pages Notes { get { return new Pages("Notes"); } }

        //App Gallery
        public static Pages Grid { get { return new Pages("Grid"); } }
        public static Pages Masonry { get { return new Pages("Masonry"); } }
        public static Pages GridAdvance { get { return new Pages("GridAdvance"); } }

        //Editor
        public static Pages CKEditor { get { return new Pages("CKEditor"); } }
        public static Pages CKEditorBallon { get { return new Pages("CKEditorBallon"); } }
        public static Pages CKEditorInline { get { return new Pages("CKEditorInline"); } }
        public static Pages CKEditorDocument { get { return new Pages("CKEditorDocument"); } }
        public static Pages TinyMCE { get { return new Pages("TinyMCE"); } }

        //Invoice
        public static Pages Invoice { get { return new Pages("Invoice"); } }
        public static Pages InvoiceSummary { get { return new Pages("InvoiceSummary"); } }
        public static Pages InvoiceList { get { return new Pages("InvoiceList"); } }

        //Full Calendar
        public static Pages FullCalendar { get { return new Pages("FullCalendar"); } }

        //File Upload
        public static Pages FileUpload { get { return new Pages("FileUpload"); } }


    }
}
