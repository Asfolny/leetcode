class Solution:
    def closestPrimes(self, left: int, right: int) -> List[int]:
        if left <= 2 and right >= 3:
            return [2, 3]

        for p in range(left, right+1):
            if p+2 > right:
                break
            if self.isPrime(p) and self.isPrime(p+2):
                return [p, p+2]

        primes = [p for p in range(left, right+1) if self.isPrime(p)]
        if len(primes) < 2:
            return [-1, -1]

        distances = [primes[d+1]-primes[d] for d in range(len(primes)-1)]
        min_distance = min(distances)
        idx = distances.index(min_distance)

        return [primes[idx], primes[idx+1]]

    def isPrime(self, num: int) -> bool:
        if num < 2:
            return False

        for i in range(2, ceil(sqrt(num))+1):
            if num % i == 0:
                return False

        return True

