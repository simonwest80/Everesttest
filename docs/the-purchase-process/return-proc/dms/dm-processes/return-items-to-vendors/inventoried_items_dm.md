---
title: Stock Status of Inventoried Items
---

# Stock Status of Inventoried Items


Inventoried items are assigned to an "out" type of stock area  when they are returned on a debit memo. The default stock area to which  the items returned are transferred is determined using the following rules:

- If a default  stock area for transferring items returned is specified in **Workstation 
 Settings** dialog box (path: **File 
 &gt; Setup &gt; Preferences** > **Work**s**tation Settings** > **Stock****Areas** > **For****Purchase** tab **** > **Transfer inventory to** section  > **Debit Memo**), the quantities  are transferred to this stock area.
- If a default  stock area is not defined in the **Workstation 
 Settings** dialog box, the items are assigned to the stock area defined  in the **Location** profile (path:  **File** > **Setup**  > **Accounting** > **Location**/  **Sub-Location** > **Options** > **Edit** > **In New Window** > **Stock Transfer** > **Purchasing** tab > **Select Stock Area to transfer inventoried 
 items into when creating** section> **Debit Memo**) of the login location/sub-location.
- If a stock  area is not defined for the login location, the items are assigned to  the stock area defined for debit memos in the default location. The default  location is specified in the **Accounting** dialog box (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab > **Default Location** field).



{:.see_also}
See also
: [Location  Profile]({{site.sc_chm}}/misc/locations.html)
