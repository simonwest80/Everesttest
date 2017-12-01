---
title: Default Address for AVS
---

# Default Address for AVS


The default address to be used for address verification is specified  in this field. The following options are available:


| **Option** | **Description** |
| Billing address of document | The cardholder's billing address as displayed on the document profile  will be verified. |
| Shipping address of document | The cardholder's shipping address as specified in the sales document  profile will be verified. If a shipping address has not been specified  on the document, the billing address will be verified. |
| Other | The address specified on the [**Card Verification** dialog box]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify-dlg/the_card_verification_dialog_box.html) will  be verified. |



The **Default address for AVS**  field in the **Credit Card** profile  defaults to the setting made in this field. You can change these settings  on the [**Credit Card** profile]({{site.mc_chm}}/misc/the_credit_card_profile.html) if required.


If you receive payment on a sales document through a new credit card  (one whose details have not been entered in your database), the **Address** and **Zip** fields of the **Card Verification**  dialog box are automatically updated with the address specified in this  field.


| **Option Selected** | **Address and Zip fields on the Card <br/> Verification dialog box updated with:** |
| Billing address of document | The customer's billing address as displayed in the sales document profile. |
| Shipping address of document | The shipping address specified in the **Ship <br/> To** field of the sales document profile. If a shipping address has  NOT been specified in the document profile, the billing address is displayed. |
| Other | The **Address** and **Zip**  fields are left blank. |



{:.see_also}
See also
: [Others  2 Tab - Documents Dialog Box]({{site.bp_baseurl}}/misc/miscellaneous_others_others_2_steps.html)
