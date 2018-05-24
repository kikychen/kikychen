user ID = E16300
Password = JIDNCE232


Crystal report
file name 'crSimple.pdf' -> simple report
file name 'crManagement.pdf' -> management report



1. Maximum log in attampt = 5 times

2. Able to search, delete or add facility sport center members

3. Able to search, delete, or add sport facility

4. For booking
a. two database table - 'facility status' & 'transaction records'
different timeslot shows as columns in 'facility status' table.
Upon 'booking form' loading => do a 'facility status' table search=>
 if there is any record dated tomorrow => no update and just show facility satus;
otherwise (start of 1st record of the day) => reset all 'facility status' timeslot columns to 'available'
c. able to book and cancel (before confirmation)
d. able to confirm the booking (update facility status and transaction table),
and cancel booking before confirmation

5. For booking (confirmed) cancellation

There are some bugs, and some features yet to implement due to time constraint 
- eg handle multiple booking, database update, etc.