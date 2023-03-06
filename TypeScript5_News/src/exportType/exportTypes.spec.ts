import { type company } from "./reExportTypes";
import { company2 } from "./reExportTypes";

// see also https://www.typescriptlang.org/docs/handbook/release-notes/typescript-3-8.html
describe("Export types", () => {
    it("should distinguish type and class imports", () => {
        let created: company.Product; // type parameter only import is OK
        // created = new company.Product(); // error: cannot be used as a value because it was exported using 'export type'.

        created = new company2.Product(); // class runtime usage
        
        expect(created).not.toBeNull();
    });
});