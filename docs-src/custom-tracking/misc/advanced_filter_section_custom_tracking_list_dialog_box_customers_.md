---
title: Advanced Filter Section - Custom Tracking List Dialog Box (Customers)
---

# Advanced Filter Section - Custom Tracking List Dialog Box (Customers)


This section allows you to set additional conditions for generating  the customers list. This section contains **Include****list** - **Group**/**Selection** and **Exclude****list** - **Group**/**Selection**.


**Include List - And/Or**


Select **And** against both Group  and Selection in the Include List to get customers who must be tagged  with all choices selected in all the groups.


Select **And** against Group and  **Or** against Selection in the Include  List to get customers who must be tagged with at least one of the choices  selected in each group for which a selection has been specified.


Select **Or** against Group and  **And**  against Selection in the Include List to get customers who must be tagged  with all choices selected in any of the groups for which a selection has  been specified.


Select **Or** against Group and  **Or** against Selection in the Include  list to get customers who must be tagged with at least one selection in  any of the groups.


![example.gif]({{site.ct_baseurl}}/img/example.gif)  You  have selected the choices ‘Local’ and ‘Monthly’ respectively for the tracking  groups ‘Territory’ and ‘Membership Type’  with customers tagged in the following manner:


 - Customer  1 is tagged to both ‘Local’ and ‘Monthly’


 - Customer  2 is tagged to only ‘Local’


 - Customer  3 is tagged to only ‘Monthly’


 - Customer  4 is tagged to other selections in both groups


 - Customer  5 is tagged to other selections in ‘Local’


 - Customer  6 is tagged to other selections in ‘Monthly’




According to the conditions you set in the  include list, the output is as follows:

| ### Group | ### Choice | ### Result |
| And | And | Customer 1 |
| And | Or | Customer 1 |
| Or | And | Customer 1 |
| Or | Or | Customer 1,2,3,4,5,6 |


**Exclude List - And/Or**


From the list of customers who match the criteria for the Include List,  you can exclude customers based on selections in the Exclude List. Advanced  filter allows you to set conditions for exclusion.


Select **And** against Group and  Selection in the Exclude **** List  to exclude customers who must be tagged with all choices selected in all  the groups for which a selection has been specified in the Exclude List.


Select **And** against Group and  **Or** against Selection in the Exclude  list to exclude customers who must be tagged with at least one of the  choices selected in each group for which a selection has been specified.


Select **Or** against Group and  **And**  against Selection in the Exclude List to exclude customers who must be  tagged with all choices selected in any of the groups for which a selection  has been specified.


Select **Or** against Group and  **Or** against Selection in the Exclude  list to exclude customers who must be tagged with at least one selection  in any of the groups.


{:.see_also}
See also
: [Custom  Tracking List Details]({{site.ct_baseurl}}/document-tracking/tracking-work-orders/create_a_custom_tracking_choice_for_work_orders.html)
