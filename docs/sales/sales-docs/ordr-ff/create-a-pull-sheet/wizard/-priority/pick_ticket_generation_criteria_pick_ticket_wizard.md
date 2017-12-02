---
title: Pull Sheet Wizard - Priority
---

# Pull Sheet Wizard - Priority


The **Priority** section determines  the display of open sales orders within the **Pick 
 Ticket** browser. This enables you to list the sales orders in the  order that you want them filled. This can increase customer satisfaction  by attending appropriately to your Customer's fulfillment needs. You can  prioritize them by the sales order date using **FIFO**  (First in First Out) or **LIFO** (Last  in First Out). You can also give priority to back orders regardless of  the sales order date.


Sales Order Priority


**FIFO (First in First Out)**
: Select this option to display sales orders in the  ascending order of creation in the **Pick 
 Ticket** browser. This is the default option and will ensure that  your oldest orders are filled first.
: ![]({{site.sp_baseurl}}/img/example.gif) You have three sales orders with  the following details:

- : 1590  dated 1**st** June 2009
- : 1025  dated 15**th** May 2009
- : 1100  dated 16**th** May 2009

: The FIFO option displays the sales orders  in the following order:

- : 1025  dated 15th May 2009
- : 1100  dated 16th May 2009
- : 1590  dated 1st June 2009



**LIFO (Last in First Out)**
: Select this option to display the sales orders created  last in the beginning of the **Pick Ticket**  browser.  This  will ensure that your most recent orders are filled first.
: ![]({{site.sp_baseurl}}/img/example.gif) Using  the same example as above, the LIFO option displays the sales orders in  the following order:

- : 1590  dated 1st June 2009
- : 1100  dated 16th May 2009
- : 1025  dated 15th May 2009



Back Order Priority


**Yes**
: Select **Yes** to  display back orders before "open" sales orders in the **Pick Ticket** browser.


![]({{site.sp_baseurl}}/img/example.gif) You have three sales  orders with the following details:

- : 1590  dated 1st June 2009
- : 1025  dated 15th May 2009
- : 1100  dated 16th May 2009 - This is a back order.

: This option (along with **FIFO** in the previous section of the wizard) displays the items on the  sales orders in the following order:

- : 1100  dated 16th May 2009
- : 1025  dated 15th May 2009
- : 1590  dated 1st June 2009

: If you select **LIFO** in the previous section of the wizard and select **Yes**  in this section the sales orders are displayed in the following order:

- : 1100  dated 16th May 2009
- : 1590  dated 1st June 2009
- : 1025  dated 15th May 2009

: ![]({{site.sp_baseurl}}/img/lens.gif) [Document  Status]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/other/document_status_document_information_sales_content.html)


**No**
: If you select **No**,  sales orders are displayed in the order specified in the **Sales 
 Order Priority** section. **No** is  selected by default.


{:.note}
The sort order of the **Pick 
 Ticket** browser cannot be modified from the browser. It is therefore  important that you decide the required sort order in the **Priority**  section of the **Pull Sheet Wizard**.


Click **Next**. You will see the  **Line 
 Items** section of the **Pull 
 Sheet Wizard**.


{:.see_also}
See also
: [The Pull Sheet  Wizard]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/the_pull_sheet_wizard.html)
