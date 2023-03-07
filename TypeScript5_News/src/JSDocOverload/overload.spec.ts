import { exponent } from "./overload";


describe("JSDoc overloads", () => {
    it("Provides new documentation", () => {
        // exponent("8", "other");// invalid call, no such overload

        // without documentation
        expect(exponent(8)).toEqual(64);

        // with documentation
        expect(exponent("8")).toEqual(64);
    });
});