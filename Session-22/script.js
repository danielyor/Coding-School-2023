// Note to self: str is null when prompt is cancelled by user.

function strRev() {
    const str = prompt("Input:");
    const output = str.split('').reverse().join('');
    alert(output);
}

function checkPalindrome() {
    const str = prompt("Input:");
    
    const re = /[\W_]/g;
    const lowRegStr = str.toLowerCase().replace(re, '');
    const reverseStr = lowRegStr.split('').reverse().join(''); 

    if (reverseStr === lowRegStr) {
        alert("It's a palindrome!");
    }
    else {
        alert("It's not a palindrome.");
    }
}

function incStringNum() {
    const str = prompt("Input:");

    let splitStr = str.split(/(\d+)/);

    if (splitStr[splitStr.length-1] == '') {
        splitStr[splitStr.length-2]++;
    }
    else {
        splitStr.push("1");
    }

    alert(splitStr.join(''));
}