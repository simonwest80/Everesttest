---
title: Pre-Authorization Information
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Pre-Authorization Information


Pre-authorization is the verification of the authenticity of the card  and the credit limit on the card without the payment being processed.  Instead, the amount is put on hold and the payment from the customer is  credited to your account on a later date after fulfillment of the order.


For settling the payment you have to send a [prior authorization](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/prior_authorization_1.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>  request with the [approval code](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/approval_code_1.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>  to the merchant bank.


{:.note}
You can select only one of the options: sale, pre-authorization  or use prior authorization while processing a payment.


The **Authorize Only** and **Book for Later Shipment** options are  enabled depending on the payment service selected.


**ICVerify**
: When the payment service is ICVerify, select **Authorize Only** to obtain an authorization  to block the processed amount. Issue a [Force Sale](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/force_sale_1.html');){:id="A3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A3');
//--></script>  transaction request with the authorization code to capture the funds.
: Select **Book for 
 later Shipment** to book amounts in case of [MO/TO](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/mo_to_1.html');){:id="A4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A4');
//--></script>  sales. Issue a [Ship (Prior Booking)](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/ship_prior_booking__1.html');){:id="A5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A5');
//--></script>  request with the authorization code to capture the funds.


{:.note}
If an authorization is not used (i.e. processed for  capture) within a certain time period, it will drop off or expire. The  bank that issues the credit card determines the time period for drop off.


Accounting Entries for Pre-authorization


No accounting entries are created for pre-authorization, as it only  blocks the funds in a cardholder's account and does not result in a charge  to the account.


{:.see_also}
See also
: [Back  End Processes - Pre- Authorization]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/pre-authorization/back_end_processes_pre_authorization.html)
: [Card Verification  Details]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/card_verification_details.html)
