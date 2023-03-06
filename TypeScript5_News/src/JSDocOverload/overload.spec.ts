import { exponent } from "./overload";


describe("JSDoc overloads", () => {
    it("Provides new documentation", () => {
        // without documentation
        expect(exponent(8)).toEqual(64);

        // with documentation
        expect(exponent("8")).toEqual(64);
    });
});