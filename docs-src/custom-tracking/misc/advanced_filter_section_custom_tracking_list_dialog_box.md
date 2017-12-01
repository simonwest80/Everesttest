---
title: Advanced Filter Section - Custom Tracking List Dialog Box
---

# Advanced Filter Section - Custom Tracking List Dialog Box


This section allows you to set further conditions for generating the  item list. This section contains **Include 
 list - Group/Selection** and **Exclude 
 list - Group/Selection**.


**Include List - And/Or**


The various selections that you can make and the results are detailed  in the table below:


| Group | Selection | Result |
| AND | AND | Items tagged with all choices selected in all the groups. |
| AND | OR | Items tagged with at least one of the choices selected in each group  for which a selection has been specified. |
| OR | AND | Items tagged with all choices selected in any of the groups for which  a selection has been specified. |
| OR | OR | Items tagged with at least one selection in any of the groups. |



**![example.gif]({{site.ct_baseurl}}/img/example.gif)  You  have selected the choices ‘A’ and ‘B’ respectively for the tracking groups  ‘C’ and ‘D’ with vendors tagged in the following manner:**


 - Vendor  1 is tagged to both ‘A’ and ‘B’
 - Vendor  2 is tagged to only ‘A’
 - Vendor  3 is tagged to only ‘B’
 - Vendor  4 is tagged to other selections in both groups
 - Vendor  5 is tagged to other selections in ‘A’
 - Vendor  6 is tagged to other selections in ‘B’




According to the conditions you set in  the include list, the output is as follows:


| Group | Choice | Result |
| AND | AND | Vendor 1 |
| AND | OR | Vendor 1 |
| OR | AND | Vendor 1 |
| OR | OR | Vendor 1,2,3,4,5,6 |



**Exclude List - And/Or**


From the list of items that match the criteria for the **Include 
 list**, you can exclude items based on selections in the **Exclude 
 List**. Advanced filter allows you to set conditions for exclusion.


The various selections that you can make and the results are detailed  in the table below:


| Group | Selection | Result |
| AND | AND | Exclude items tagged with all choices selected in all the groups for  which a selection has been specified. |
| AND | OR | Exclude items tagged with at least one of the choices selected in each  group for which a selection has been specified. |
| OR | AND | Exclude items tagged with all choices selected in any of the groups  for which a selection has been specified. |
| OR | OR | Exclude items tagged with at least one selection in any of the groups. |



{:.see_also}
See also
: [Custom  Tracking List Details]({{site.ct_baseurl}}/item-tracking/custom_tracking_list_details.html)
