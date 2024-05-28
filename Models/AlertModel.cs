using edxl_cap_v1_2.Models.ContentViewModels;

namespace edxl_cap_v1_2.Models
{
    class AlertModel : EdxlCapMessageViewModel
    {
        new int AlertIndex { get; set; }

        new int SelectedAlertIndex { get; set; }

    }
}
