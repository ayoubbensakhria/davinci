class Solution:
    def numUniqueEmails(self, emails: List[str]) -> int:
        validEmails = []
        for email in emails:
            if "@" in email:
                localName = email.split('@')[0]
                # remove '.' and after '+'
                localName = localName.replace(".", "")
                if "+" in localName:
                    localName = localName.split('+')[0]
                newEmail = localName + "@" + email.split('@')[1]
                if newEmail not in validEmails:
                    validEmails.append(newEmail)
        return len(validEmails)