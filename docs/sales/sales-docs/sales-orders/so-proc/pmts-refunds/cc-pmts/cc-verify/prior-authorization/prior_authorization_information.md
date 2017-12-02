---
title: Prior Authorization Information
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Prior Authorization Information


The **Use Prior Authorization**  section in the **Card Verification**  dialog box is used for processing payments on cards, which are pre-authorized.  Upon fulfillment of the order, when the payment becomes due, the amount  for which [prior authorization](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/prior_authorization_1.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>  is obtained must be processed to [capture](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/capture_1.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>  funds.


**ICVerify**
: When the payment service is ICVerify, select **Force Sale** to capture funds on an existing  [voice authorization](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/voice_authorizations.html');){:id="A3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A3');
//--></script>  or other [authorization](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/authorization_1.html');){:id="A4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A4');
//--></script>.  Select **Ship (Prior Booking)** to  capture amounts that have been booked through prior authorization in case  of [MO/TO](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/mo_to_1.html');){:id="A5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A5');
//--></script>  sales.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Credit  Card Processing with IC Verify]({{site.sc_chm}}/misc/credit_card_processing_ic_verify.html)
: When this option is selected, you have to select  the approval code for the amount which you have previously obtained.
: If this amount is MORE than what you enter in the  payment details window, **Everest**  prompts you with the following message and options:
: “The amount being processed is less than the previously  authorized amount of XX.XX for the selected approval code.  How  would you like to proceed?"

- Receive partial  payment of YY.YY and maintain the difference of ZZ.ZZ for future re-authorization
- Receive partial  payment of YY.YY

: The variables mentioned above stand for the following:
: YY.YY is the amount the user entered in the payment  screen
: XX.XX is the amount of the Batch Payment Record  (authorized amount)
: ZZ.ZZ is equal to XX.XX - YY.YY.
: Depending on your selection, the respective action  will be taken.
: In case you select an approval code for an amount  that is LESS than what you enter in the payment details window, **Everest** prompts you with the following  message:
: "The maximum amount that can be processed using  the selected approval code is XX.XX.  Would  you like to adjust this payment to use this amount?"
: If you select Yes, the transaction is submitted  for amount XX.XX. If you select No, the transaction is not submitted and  you are returned to the **Credit Card Processing**  dialog box.


**Payflow  Pro**
: When the payment service is Payflow  Pro, select **Voice Authorization** to  capture funds on an existing voice authorization or any other authorization.  Select **Delayed Capture** to capture  amounts that are booked through prior authorization in case of MO/TO sales.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Credit  Card Processing with Payflow  Pro]({{site.sc_chm}}/misc/credit_card_processing_payflow_pro.html)


**Approval Code/PNRef #**
: Enter the approval code, if it is a voice authorization.  In case of existing authorizations, select the approval code.
: In case the payment service is Payflow  Pro and the option selected is **Delayed 
 Capture** select the appropriate PNREF number  (Payment Network Reference Number) in this field.


{:.note}
You can select only one of the options: new payment,  sale, pre-authorization or use prior authorization while processing a  payment.


**Accounting Entries for Prior Authorization**


The accounting entries for approved payments are the same as the entries  made when payment is made through cash, check or any other method.


![]({{site.sp_baseurl}}/img/lens.gif) [Accounting Entries -  Payments from Customers]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/pmts-on-so/rcpt-dlg/accounting_entries.html)


{:.see_also}
See also
: [Back  End Processes - Prior Authorization]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/prior-authorization/back_end_processes_prior_authorization.html)
: [Card Verification  Details]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/card_verification_details.html)
