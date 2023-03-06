export interface Options {
    switches?: string | string[];
}

export const customOptions = {
    switches: "c"
} satisfies Options; // TS4 satisfies checks, that it switches are correctly string

// TS5 also visible as part of the documentation
/**
 * @satisfies Options
 */
export const documentedOptions = {
    switches: ["a", "b"]
} satisfies Options;
