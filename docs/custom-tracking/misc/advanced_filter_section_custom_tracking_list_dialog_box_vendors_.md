---
title: Advanced Filter Section - Custom Tracking List Dialog Box (Vendors)
---

# Advanced Filter Section - Custom Tracking List Dialog Box (Vendors)


This section allows you to set further conditions for generating the  vendor list. This section contains **Include 
 list - Group/Selection** and **Exclude 
 list - Group/Selection**.


**Include List - And/Or**


The various selections that you can make and the results are detailed  in the table below:


| Group | Selection | Result |
| AND | AND | Vendors tagged with all choices selected in all the groups. |
| AND | OR | Vendors tagged with at least one of the choices selected in each group  for which a selection has been specified. |
| OR | AND | Vendors tagged with all choices selected in any of the groups for which  a selection has been specified. |
| OR | OR | Vendors tagged with at least one selection in any of the groups. |



![example.gif]({{site.ct_baseurl}}/img/example.gif)  You  have selected the choices ‘Legal’ and ‘Refund’ respectively for the tracking  groups ‘Vendor Classification’  and ‘Warranty Policy’  with vendors tagged in the following manner:


 - Vendor  1 is tagged to both ‘Legal’ and ‘Refund’


 - Vendor  2 is tagged to only ‘Legal’


 - Vendor  3 is tagged to only ‘Refund’


 - Vendor  4 is tagged to other selections in both groups


 - Vendor  5 is tagged to other selections in ‘Legal’


 - Vendor  6 is tagged to other selections in ‘Refund’




According to the conditions you set in  the include list, the output is as follows:


| Group | Choice | Result |
| And | And | Vendor 1 |
| And | Or | Vendor 1 |
| Or | And | Vendor 1 |
| Or | Or | Vendor 1,2,3,4,5,6 |



**Exclude List - And/Or**


From the list of vendors who match the criteria for the **Include 
 list**, you can exclude vendors based on selections in the **Exclude List**. Advanced filter allows  you to set conditions for exclusion.


The various selections that you can make and the results are detailed  in the table below:


| Group | Selection | Result |
| AND | AND | Exclude vendors tagged with all choices selected in all the groups for  which a selection has been specified. |
| AND | OR | Exclude vendors tagged with at least one of the choices selected in  each group for which a selection has been specified. |
| OR | AND | Exclude vendors tagged with all choices selected in any of the groups  for which a selection has been specified. |
| OR | OR | Exclude vendors tagged with at least one selection in any of the groups. |



{:.see_also}
See also
: [Custom  Tracking List Details]({{site.ct_baseurl}}/vendor-tracking/custom_tracking_list_details_vendors.html)
