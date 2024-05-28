using edxl_cap_v1_2.Models.ContentViewModels;

namespace edxl_cap_v1_2.Models
{
    class AreaModel : EdxlCapMessageViewModel
    {
        int AreaIndex { get; set; }

        int SelectedAreaIndex { get; set; }
    }
}
