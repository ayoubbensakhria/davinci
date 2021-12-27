class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        groups = collections.defaultdict(list)
        for s in strs:
             groups[tuple(sorted(s))].append(s)
        return map(sorted, groups.values())

#----------------------------------------------------------------
# Solution 2
#----------------------------------------------------------------
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # sort and group
        groups = itertools.groupby(sorted(strs, key=sorted), sorted)
        # return values
        return [sorted(members) for _, members in groups]