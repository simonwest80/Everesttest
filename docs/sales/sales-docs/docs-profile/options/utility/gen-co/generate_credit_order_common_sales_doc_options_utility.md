---
title: Generate Credit Order
---

# Generate Credit Order


If a customer wishes to return an item, you can create a credit order  directly from a saved **Sales Invoice**  profile by using the **Generate Credit 
 Order** option (path: **Options &gt; 
 Utility &gt; Generate Credit Order**).  All  the details present in the **Sales Invoice**  profile are automatically copied into the **Credit 
 Order** profile saving the time of re-entering data.


{:.note}
You can access the **Generate 
 Credit Order** option only from a **Sales 
 Invoice** profile.


{:.steps}
To generate a credit order directly from  a Sales Invoice profile, do the following:

- From the **Sales Invoice** profile, select **Options &gt; Utility &gt; Generate Credit Order**.  You will see the **** [**Generation of Credit Order** **from 
 Sales Invoice** browser]({{site.sp_baseurl}}/sales-docs/docs-profile/options/utility/gen-co/generation_of_credit_order_browser_sales.html) listing the items in the sales invoice  document for which no credit order has been created, for the sales transaction.
- From the **Generation of Credit Order** browser,  choose the line items for which you want to create a credit order by selecting  the check box beside the item, and select **Options 
 &gt; Create CO**.



{:.note}
By default all the items are selected.


You will be informed that a credit order has been created. You will  also be asked whether you want to open the credit order document. Click  **Yes** to view the **Credit 
 Order** profile. Click **No**  to return to the **Generation of Credit 
 Order from Sales Invoice** browser.


By default, a credit quote is created automatically when you create  a credit order from a sales invoice document. You can view the credit  quote details from the document status section of the credit order document.


![]({{site.sp_baseurl}}/img/lens.gif) [Document  Status]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/other/document_status_document_information_sales_content.html)


The **CO Reference** column in the  Item Details Grid of the **Sales Invoice**  profile displays the credit order number. You can double-click on the  column to view the credit order.


![]({{site.sp_baseurl}}/img/lens.gif) [CO  Reference]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/item-info/other/co_reference_item_details_grid_sales_content.html)


The **SI 
 Reference** column in the Item Details Grid of the **Credit 
 Order** profile displays the sales invoice number from which you  created the credit order.


The quantity in the **Requested**  column in the Item Details Grid of the **Credit 
 Order** profile will display the quantity specified in the **Shipped** column in the Item Details Grid  of the **Sales Invoice** profile.


{:.note}
- You can edit the  quantity for each line item in the **Ordered**  column of the **Generation of Credit Order****from Sales Invoice** browser.
- You have to manually  attach serial numbers to serialized items in the **Credit 
 Order** profile or you can generate serial numbers by selecting the  option **Attach/Retrieve Serial Number 
 &gt; Generate Serial Number**.
