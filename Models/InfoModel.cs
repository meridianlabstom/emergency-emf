using edxl_cap_v1_2.Models.ContentViewModels;

namespace edxl_cap_v1_2.Models
{
    class InfoModel : EdxlCapMessageViewModel
    {
        int InfoIndex { get; set; }

        int SelectedInfoIndex { get; set; }
    }
}
