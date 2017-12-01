---
title: Example of a Template
---

# Example of a Template


Consider you have new customers who have joined your existing customer  base. You may want to greet all new customers by sending them a welcome  e-mail. To do so, you can specify the following format:


Dear <#CUSTFIRSTNAMECONT>  <#CUSTLASTNAMECONT>,


We at <#LEGALCOMPNAME>  welcome you to our existing customer base and look forward to a long and  fruitful association with you. Your date of joining us as a customer is  <#SYSCURRDATE|D4|>.


We also look forward to your feedback from time to time to enable us  to provide the best services for our customers.


Regards,


Staff members


<#LEGALCOMPNAME>


In the above format, the tags will be replaced by actual data in the  output.


{:.note}
The format specifier should be inserted before  the closing braces of the tag as shown in the example.


In **Everest CRM**,  there are some [Special Tags]({{site.crm_baseurl}}/misc/special_tags.html) that result  in additional output when the action is executed.
