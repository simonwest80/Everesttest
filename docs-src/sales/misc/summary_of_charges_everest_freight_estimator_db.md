---
title: Summary of Charges
---

# Summary of Charges


This section displays the freight charges, the freight padding amount,  special pricing if any and the total freight for the document.


**Freight**
: This field displays the freight amount. Click the  ![]({{site.sp_baseurl}}/img/sales_freight_details_lookup_button.gif) button to view a breakup of the freight charges. You  will see the [**Freight Details** dialog box]({{site.sp_baseurl}}/misc/freight_details_dialog_box_freight_estimation.html).


**[]()Padding**
: While shipping goods, you may want to charge your  customers an additional amount/percentage over the actual freight charges.  This is called the freight padding amount.


**You can specify the freight padding amount or  percentage in:**

- The **Padding 
 and Padding Amount/%** fields of the [**Carrier** profile]({{site.sc_chm}}/misc/delivery_method_profile_rate_tab.html) (path: **File 
 &gt; Setup &gt; Freight &gt; Carrier &gt; Options &gt; Edit &gt; In New 
 Window &gt; Additional Rates** tab).
- The **Padding**  and **Padding** **Amount**/**Percent** fields of the [**Other Defaults** dialog box]({{site.bp_chm}}/other-defaults/the_other_defaults_dialog_box.html) (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Other Defaults**).



If you specify a freight padding amount or percentage in both the **Carrier** and the **Other****Defaults** dialog box, the value  specified in the **Carrier** profile  takes precedence (provided the carrier for which freight padding is specified,  is the carrier for the delivery method specified on the document) and  is displayed in the **Padding** **Amount** field. You can edit this field.


You compute freight on an intermediate document and then specify a different  amount/percentage (in the **Carrier**  profile or **Other Defaults** dialog  box). When you later convert the document into a final document, **Everest** prompts you that the amount/percentage  specified differs from that of the document. You can choose if you want  to use the new value or not.


{:.note}
If freight padding has been specified as a percentage  in the **Other** **Defaults**  dialog box/**Carrier** profile, and  you modify the **Padding** **Amount**  field by entering an amount, **Everest**  considers the padding type for the document as 'amount' and not as a 'percentage'.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Freight  Padding Applied]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/delivery/freight_padding_applied_common_sales_content.html)


**Special Pricing**
: If you have specified a special price for the freight  charged on documents, **Everest**  calculates and displays the amount in this field. You can specify this  in the [**Special Pricing** dialog box]({{site.mi_chm}}/misc/special_pricing_details_section_special_pricing_db.html) by specifying  **Freight** in the **Discount****Type** field (path: **Inventory 
 &gt; Discounts &gt; Special Pricing &gt; Options &gt; New &gt; In New 
 Window**).
: This is a display field and cannot be edited.


**Total**
: The freight amount charged on the document, including  the freight padding and special pricing amount, if any, is displayed in  this field.
: Total = Freight + Padding + Special Pricing


{:.see_also}
See also
: [The  Everest Freight Estimator Dialog Box]({{site.sp_baseurl}}/sales-docs/docs-profile/options/utility/freight-est/everest-freight-estimator/the_everest_freight_estimator_dialog_box.html)
