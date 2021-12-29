public class Solution {
    public int NumUniqueEmails(string[] emails) {
        // split at @
        // replace . by empty
        // split at + and ignore part 2
        List<string> result = new List<string>();
        foreach(string email in emails){
            if(email.Contains("@")){
                string localName = email.Split('@')[0];
                // remove . from the localName
                localName = localName.Replace(".", "");
                // remove 2end part after +
                if(localName.Contains("+")){
                    localName = localName.Split('+')[0];
                }
                string newEmail = localName + '@' + email.Split('@')[1];
                if(!result.Contains(newEmail)){
                    result.Add(newEmail);                    
                }
            }
        }
        return result.Count;
    }
}