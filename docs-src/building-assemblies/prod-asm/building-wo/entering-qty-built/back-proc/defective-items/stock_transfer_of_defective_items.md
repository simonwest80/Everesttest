---
title: Stock Area to which Defective Items are Transferred
---

# Stock Area to which Defective Items are Transferred


You can define a stock area for transferring assembled defective items  in the **Select stock area to receive completed 
 defective assembly items** field of the **Location** profile (path: **File** >  **Setup** > **Accounting**  > **Location**/**Sub-Location**  > **Options** > **Edit**  > **In New Window** > **Stock** **Transfer**  > **Assembly** **2**  tab).


![]({{site.ba_baseurl}}/img/lens.gif) [Location  Profile - Stock Transfer - Assembly 2 Tab ]({{site.sc_chm}}/misc/stock_transfer_assembly_2.html)


If a stock area is not defined for the logged in location or sub-location,  the stock area assigned for the default location in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field) is used.


![]({{site.ba_baseurl}}/img/lens.gif) [Default  Location]({{site.sc_chm}}/misc/default_location.html)


If the preference in the default location is also blank, when you try  to save the **Build** profile (with  defective items), **Everest** prompts  you to confirm whether you want to use the default stock area for receiving  items on purchase receipts or invoices. The default stock area for purchase  receipts and invoices is specified in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location** > **Options** > **Edit** > **In 
 New Window** > **Stock** **Transfer** > **Purchase 
 Document** tab).

- Click **Yes** to transfer defective  items to the stock area (for purchase receipts/invoices) for the logged  in location. If the stock area has not been defined for the login location  also, the default stock area (for purchase receipts/invoices) for the  default location is used.
- If you click  **No**, the build details are not  saved.



{:.see_also}
See also
: [Back  End Processes - Defective Items]({{site.ba_baseurl}}/prod-asm/building-wo/entering-qty-built/back-proc/defective-items/backend_process_defective_items.html)
