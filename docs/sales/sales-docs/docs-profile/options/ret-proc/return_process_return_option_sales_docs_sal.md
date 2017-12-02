---
title: Return Process - Return
---

# Return Process - Return


The **Return** option  allows you to process a return for an item.


{:.steps}
To process a return, do the following:

- Select **Options**  > **Return Process** > **Return**. The **Return 
 Processing** dialog box displays.
- Select the **Select Document #** radio button and select  the sales invoice # from the drop-down list. The line items from the invoice  are populated in the lower section of the dialog box.
- Select the items  to be returned.
- Click **OK**.  The **Stock Area** field is enabled  at the bottom of the dialog box according to your preferences settings.  (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Documents**  > **Prompts** > **Sales 
 Document** > **Sales Document 1**  tab).

: ![]({{site.sp_baseurl}}/img/lens.gif) [Prompt  method for selecting a stock bin while returning on documents]({{site.bp_chm}}/misc/prompt_method_for_selecting_a_stock_bin_while_returning_on_documents_content_documents_db_bp.html)


![]({{site.sp_baseurl}}/img/return_processing_browser_stock_area_field_sal.gif)


**Figure: Return Processing browser – Stock Area  field**

- Select the stock  bin to receive the items from the drop-down list of this field and press  **Enter**. The sales invoice profile  populates with the selected items.



{:.note}
The **Select Stock Area**  field is displayed once for all items or once for each line item depending  upon your preference settings (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Prompts** > **Sales 
 Document**  >  **Sales Document 1** tab).

- If  the  preferences are set to **Use Default**,  the system does not enable the Stock Area field.
- If the preferences  are set to **Once for each item**,  the **Stock Area** field is enabled.  Select a stock bin for the first line item and press **Enter**.  The second line item is selected and you can select the stock bin for  the second line item next. This process continues for as many line items  as you have and the line items are displayed in the invoice.
- If the preferences  are set to **Once for all items**,  select a stock bin and press **Enter**.

- Select any other  items to be shipped by adding rows and selecting items on the sales invoice.
- The system does  not allow you to save a sales invoice for an amount less than zero and  if the amount due from the customer is positive. The total amount of goods  being returned should be less than the total cost of the items that are  being shipped. Save the sales invoice.



{:.see_also}
See also
: [Return  Process]({{site.sp_baseurl}}/sales-docs/docs-profile/options/ret-proc/return_process_common_browser_options_sales_docs_contents_sal.html)
