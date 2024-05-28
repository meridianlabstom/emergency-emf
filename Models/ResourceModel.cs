using edxl_cap_v1_2.Models.ContentViewModels;

namespace edxl_cap_v1_2.Models
{
    class ResourceModel : EdxlCapMessageViewModel
    {
        int ResourceIndex { get; set; }

        int SelectedResourceIndex { get; set; }
    }
}
