---
title: The Documents Dialog Box - Pricing/Discounts
---

# The Documents Dialog Box - Pricing/Discounts


The **Pricing/Discounts**  tab defines flow control preferences to determine the use of pricing and  discounts in documents. **Everest**  automatically executes the specified pricing/discount option or prompts  the user for inputs for pricing/discount options as set and enabled in  this tab.


The options for pricing/discount settings are:

- [When  applying document discounts how should the discount be applied?]({{site.bp_baseurl}}/misc/when_applying_document_discounts_how_should_the_discount_be_applied_.html)
- [Behavior  for price column if quoted/ordered quantity is changed and new price is  available]({{site.bp_baseurl}}/misc/behaviour_for_price_column_if_quantity_is_changed_and_a_new_price_is_available.html)
- [Customer  level price to override list price for price calculation]({{site.bp_baseurl}}/misc/customer_level_price_to_override_list_price_for_price_calculation.html)
- [Automatically  apply item discounts applicable to a customer when retrieving the item  on a document]({{site.bp_baseurl}}/misc/automatically_apply_item_discounts_applicable_to_a_customer_when_retrieving_the_item_bp.html)
- [Ignore  special pricing for matrix groups and element tracking]({{site.bp_baseurl}}/misc/ignore_special_pricing_for_matrix_groups_and_element_tracking_bp.html)



The **Pricing/Discounts**  tab provides preference settings to determine if price or discount % type  discount should be applied.


**When applying document discounts how should the  discount be applied?**
: This field identifies how global discounts are applied.  You can select **Options &gt;** **Document** > **Document 
 Discount** from the sales document profile and specify the discount  percent. When applying discounts in sales documents, you can reduce the  **Item Price**, or retain the item  price and display the Discount Amount applied. Select one of the following  options to apply the document discount:


| **Option** | **Description** |
| Discount% | The discount amount and percentage are displayed in the respective columns  for each item in the document. |
| Price | The item price displayed in the document is reduced by the discount  amount. The discount columns do not display any values. |



{:.example}
**A company allows a discount of 3% on total  bill amount while another company gives a discount price of $25 on the  total bill amount if the bill amount exceeds $250. The settings allow  you to select the correct option.**


**Behavior for price column if quoted/ ordered  quantity is changed and new price is available**
: **Everest**  allows you to define how should the price alter when the quoted/ordered  quantity is changed and new price is available.


{:.example}
**A company orders a pack of 100 CD-ROMs at  a price of $75. It later changes the order to 10 packs of 1000 CD-ROMs.  The vendor gives a special discount price of $700 instead of $750. Various  options are available as shown below to apply pricing in such an instance.**
: The price applicable to an item is calculated after  considering all pricing schemes when you retrieve the item into the sales  document. If the quantity of an item is changed and thus another price  becomes applicable to the item, the price may be changed automatically  or **Everest** may prompt you depending  on the option selected in this field. **Everest**  provides you with the following options:


| **Option** | **Description** |
| Do not change | Price on the document will not be updated even if there  is a difference between the item price on the document and the new price  that becomes applicable. |
| Auto change | The price on the document will automatically be updated  as per the new price that becomes applicable. By default, this will be  selected. |
| Prompt before change | Prompts you when there is a price change. |
| Auto-change only if new price is lower | The document price will automatically be updated only  if the new price is lower. If the new price is higher, the existing line  item price on the document is retained. |
| Auto-change only if new price is higher | The document price will automatically be updated only  if the new line item price is higher. If the new price is lower, the existing  line item price on the document is retained. |
| Auto-change if new price is lower, Prompt if new price is higher | Prompts for the change in price only when the new price  is higher than the price on the document. Otherwise it will automatically  update the document price. |
| Auto-change if new price is higher, Prompt if new price is lower | Prompts for the change in price only when the new price  is lower than the price on the document. Otherwise it will automatically  update the document price. |
| Do not change if new price is higher, Prompt if new price is lower | Prompts for the change in price only when the new price  is lower than the price on the document. Otherwise the document price  will not be updated. |
| Do not change if new price is lower, Prompt if new price is higher | Prompts for the change in price only when the new price  is higher than the price on the document. Otherwise the document price  will not be updated. |



{:.note}
This option is applicable only if the quoted or ordered quantity is  changed in a sales document. It is not applicable when a sales order is  converted to a sales invoice and the shipped quantity is altered, and  when there is a change in the ordered quantity for a partially shipped  sales document.


**Customer level price to override list price for  price calculation**
: This option alters the manner in which the least  price is determined in sales orders and invoices. **Everest**  considers five types of pricing to arrive at the least price:

- List price  (Fixed price/Mark up)
- Customer level  price
- Quantity pricing
- Promotional  pricing
- Special pricing  (Discount percent from least price/ Discount fixed amount from least price/Fixed  price/Markup over last landed cost/Mark up over average cost/Fixed amount  over cost/ Level pricing)

: If this option is not checked, the least of the  above five prices is considered.
: If this option is selected, the List Price is overridden  with the Customer Level Price if it is defined and only Customer Level  price, Quantity pricing, Promotional pricing, and Special pricing are  considered to arrive at the least price.
: If this option is selected and a Customer Level  price is not defined, only the List Price, Quantity Pricing, Promotional  pricing, and Special pricing are considered to arrive at the least price.
: Click the following link to view an example:

- [Example  - Customer level price to override list price for price calculation]({{site.bp_baseurl}}/misc/example_customer_level_price_to_override_list_price_for_price_calc_pur.html)



**Automatically apply item discounts applicable  to a customer when retrieving the item on a document**
: This option automatically applies item discounts  based on special pricing rules or quantity discounts for selected customer  levels, when items are retrieved into a sales document. The discounts  related to items are defined in the **Sales**  tab of the **Item** profile (path:  **Inventory &gt; Items &gt; Options &gt; 
 Edit &gt; In New Window**).
: ![]({{site.bp_baseurl}}/img/lens.gif)  [Item  Profile]({{site.mi_chm}}/create-regular-items-kits-and-assemblies/creating-an-item/setting_up_an_item.html)


{:.example}
**Item discounts are set for special items like  computer consumables for customers who place bulk orders.  **Everest**  allows you to apply the special pricing allowed for the customer when  such an item is pulled into a document.**


**Ignore special pricing for matrix groups and  element tracking**
: Check this box to exclude special pricing rules  that have been assigned to matrix groups or custom tracking assigned to  matrix elements.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Special  Pricing for an Item Matrix Group]({{site.mi_chm}}/creating-matrix-group-and-matrix-items/pricing/special_pricing_for_an_item_matrix_group_mi.html)


{:.example}
**A garment company sells more than 10,000 varieties  of garments which are inventoried as matrix groups/items. The company  also sells 50 different items as accessories. For setting a special discount  only for the accessories, apply special pricing to all the items in the  **Special Pricing** browser (path:  **Inventory** > **Discounts**  > **Special Pricing**), and select  this checkbox to ignore the special pricing for the matrix groups.**


{:.see_also}
See also
: [Document  Flow Control Details]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/the_flow_control_setup_dialog_box_businesss_process_in_everest_content.html)
: [Set Flow  Control Options for Documents]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/setting_flow_control_options.html)
