#---------------------------------------------------------------
# Solution 1
#---------------------------------------------------------------
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # sort and group
        dict = collections.defaultdict(list)
        # return values
        for s in strs:
            sorted_list = list(s)
            sorted_list.sort()
            sorted_string = ''.join(sorted_list)        
            dict[sorted_string].append(s)
        return dict.values()
#---------------------------------------------------------------
# Solution 2
#---------------------------------------------------------------
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        groups = collections.defaultdict(list)
        for s in strs:
             groups[tuple(sorted(s))].append(s)
        return map(sorted, groups.values())

#----------------------------------------------------------------
# Solution 3
#----------------------------------------------------------------
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # sort and group
        groups = itertools.groupby(sorted(strs, key=sorted), sorted)
        # return values
        return [sorted(members) for _, members in groups]