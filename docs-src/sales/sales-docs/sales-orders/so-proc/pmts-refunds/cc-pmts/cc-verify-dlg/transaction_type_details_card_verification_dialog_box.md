---
title: Transaction Type Details
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Transaction Type Details


**Sale**
: Select this option to deliver items to the customer  as soon as payment is received.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Sale  Details]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/sale-details/sale_details_credit_card_sales.html)


Authorization
: Select this option when you merely want the amount  receivable to be blocked in the customer's account.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Authorization  Information]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/pre-authorization/pre_authorization_information.html)


**Authorize Only**
: Select this option to obtain an authorization to  block the processed amount.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Authorization  Information]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/pre-authorization/pre_authorization_information.html)


**Book for Later Shipment**
: Select this option to book or put on hold amounts  in the customer's account.
: ![]({{site.sp_baseurl}}/img/example.gif) A  merchant can use this option on receiving a payment on a mail order. The  payment is captured later after shipping the goods.


{:.note}
The **Authorize Only**  and **Book for Later Shipment** options  are available only if the payment service for credit processor is ICVerify  and the type of business is Mail Order.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Book  for Later Shipment]({{site.sp_baseurl}}/misc/book_for_later_shipment.html)
: [Pre  Authorization Information]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/pre-authorization/pre_authorization_information.html)


Use Prior Authorization
: Select this option if you have received pre authorization  for payment and now want to [capture](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/capture_1.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>  funds.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Prior  Authorization Information]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/prior-authorization/prior_authorization_information.html)


**Force Sale**
: Select this option to capture funds on an existing  voice authorization or any other authorization. This option appears only  for mail order type of businesses.<font color="#000000" class="hcp4"><font style="font-family: Verdana;" face="Verdana"> </font></font>
: ![]({{site.sp_baseurl}}/img/lens.gif) [Prior  Authorization Information]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/prior-authorization/prior_authorization_information.html)


**<font color="#000000" class="hcp4">Voice Authorization</font>**
: Select this option to capture amounts by submitting  payment information over the phone.


![]({{site.sp_baseurl}}/img/example.gif) Sometimes  during authorization, the processing network declines transactions with  a referral message indicating that the merchant must call the cardholder's  issuing bank to complete the transaction.


**Delayed Capture/Ship (Prior Booking)**
: Select this option to [capture](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/capture_1.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>  amounts that are booked through [prior authorization](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/prior_authorization_1.html');){:id="A3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A3');
//--></script>  in case of MO/TO sales.
: Depending on the payment service selected for the  credit card processor the name of the option changes.


| Payment Service | Option Displayed |
| : ICVerify | : Ship (Prior Booking) |
| : Payflow  Pro | : Delayed Capture |



**Approval Code/PNRef #**
: Enter the reference number provided by the credit  card company when prior authorization is obtained through the payment  service.
: Depending on the payment service selected for the  credit card processor the name of the option changes.


| Payment Service | Option Displayed |
| ICVerify | Approval Code |
| Payflow  Pro | - PNRef # when  you select **Delayed Capture**<br/>- Approval Code  when you select **Voice Authorization** |



Verify AVS/CVV2  only
: Select this option to verify the address and the  card verification value of the cardholder. The payment amount is not processed  when you select this option.
: This option overrides the action of the options  **Process payment and store AVS response**  and **Process payment and store CVV2 response**  selected in the **Payment Method**  dialog box (path: **File &gt; Setup &gt; 
 Accounting &gt; Payment Methods &gt; Payment Methods** browser **&gt; Edit &gt; In New Window &gt; Payment 
 Method** profile **&gt; Credit Card 
 Processing** tab **&gt; Fraud Prevention**  section).
: ![]({{site.sp_baseurl}}/img/lens.gif) [Address  Verification Details]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/address_verification_details.html)
: [Security  Code Verification Details]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/security_code_verification_details_sales.html)


{:.see_also}
See also
: [The  Card Verification Dialog Box]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify-dlg/the_card_verification_dialog_box.html)
