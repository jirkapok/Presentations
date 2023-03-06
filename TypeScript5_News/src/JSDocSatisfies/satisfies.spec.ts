import { customOptions, documentedOptions } from "./satisfies";


describe("JSDoc satisfies", () => {
    it("Provides new documentation", () => {
        // without hover documentation
        expect(customOptions.switches).not.toBeNull();

        // with hover documentation
        expect(documentedOptions.switches).not.toBeNull();
    });
});