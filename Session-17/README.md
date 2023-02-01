**1. Πως μπορούμε να κάνουμε ένα Request σε ένα εξωτερικό API χωρίς να γνωρίζει ολόκληρο το url μας;**  
Χρησιμοποιώντας το header `Referrer-Policy: no-referrer`.
https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Referrer-Policy

**2. Αν κάνω ενα GET request και ζητήσω ενα jpeg image, το response τι content-type πρεπει να εχει;**  
Ο server οφήλει ιδανικά να γυρίσει response με `Content-Type: image/jpeg`.
https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Accept
https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type

**3. Πως μπορώ να κάνω ένα GET request και το περιεχόμενο του να κρατηθεί στην cache για 1 μέρα;**  
Με τη χρήση του header `Cache-Control: max-age=86400` στο request.
https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Cache-Control
https://developer.mozilla.org/en-US/docs/Web/HTTP/Caching#fresh_and_stale_based_on_age

**4. Μπορώ να έχω μια εφαρμογή που κάνει μόνο GET requests;**  
Πρακτικά ναι, αλλά η χρήση της θα είναι περιορισμένη μόνο στο να αποκτάει δεδομένα. Δεν θα μπορεί να κάνει π.χ. form submitting.

**5. Μπορώ να έχω μια εφαρμογή που κάνει μόνο POST requests;**  
Ναι. Ένα παράδειγμα θα ήταν μια εφαρμογή που μόνο θέλει να ανεβάζει δεδομένα κάπου.

**6. Τι status code περιμένω από ένα API αν δεν έχω στείλει ένα υποχρεωτικό πεδίο;**  
`400 Bad Request`.
https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/400

**7. Τι status code περιμένω από ένα API αν δεν υπάρχει επικοινωνία με τη βάση;**  
`500 Internal Server Error` σε περίπτωση κάποιου γενικού προβλήματος ή `503 Service Unavailable` αν πρόκειται για μια προσωρινή κατάσταση π.χ. εξαιτίας maintenance.

**8. Μπορώ να κάνω Login με GET request;**  
Μπορεί αλλά δεν πρέπει να γίνει! Με τη χρήση URL parameters, παράδειγμα: `GET http://mysite.com/index.html?username=john&password=strongpassword123`
Προφανώς θα πρέπει και ο server να το επιτρέπει.

**9. Ποια είναι η διαφορά ανάμεσα στο PUT και στο POST;**  
Έχουν κάποια κοινά και μερικές διαφορές, αλλά είναι κατάλληλα για διαφορετικές λειτουργίες.
Στην πράξη, χρησιμοποιούμε την PUT για την ενημερώση κάποιου πόρου και την POST για την δημιουργία κάποιου πόρου.

**10. Ποια μέθοδο θα πρέπει να χρησιμοποιήσω για να «ανεβάσω» ένα αρχείο;**  
Την μέθοδο POST.