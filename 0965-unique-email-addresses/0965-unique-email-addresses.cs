public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<String> normalize = new HashSet<String>();
        foreach( var email in emails){
            var part = email.Split("@");
            var local = part[0];
            var domain = part[1];

            int plus = local.IndexOf("+");
            if(plus != -1) local = local.Substring(0, plus);
            local= local.Replace(".","");
            normalize.Add(local + "@" + domain);
        }
        return normalize.Count;

    }
}