describe("Suite to test the registration API", () => {
    const axios = require('axios');
    const baseUrl = `http://localhost:5000`;
    const client = axios.create({
        baseURL: baseUrl
    })
    const uuidv1 = require('uuid/v1');
    
    describe("when calling /health", () => {
        it("should return status code OK (200)", async () => {
            const response = await client.get('health');
            expect(response.status).toBe(200);
        })
    });
    
    describe("when calling /applications/<application-id>", () => {
        it("should return an application", async () => {
            var id = uuidv1();
            const response = await client.get(`applications/${id}`);
            expect(response.status).toBe(200);
        }) 
    });
});